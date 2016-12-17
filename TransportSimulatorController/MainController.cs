using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public class MainController
    {
        private System.Timers.Timer startDelay;
        private static int HUNDRED_KM = 100;
        private List<Vehicle> vehicleList = new List<Vehicle>();
        public Road road;
        IMainActions mainView;
        FuelController fuelController;
        VehicleController vehicleController;
        Stopwatch sw = new Stopwatch();
        public MainController(IMainActions mainView)
        {
            road = new Road();
            this.mainView = mainView;
            mainView.setController(this);
            fuelController = new FuelController(mainView.getFuelView());
            vehicleController = new VehicleController(mainView.getVehicleControlView(), fuelController, vehicleList);
            updateFuelStatus();
            startDelay = new System.Timers.Timer();
            startDelay.Interval = 1000;
            startDelay.Elapsed += startDelay_Elapsed;
        }
        private Boolean running = false;
        private void startDelay_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            running = true;
        }
        public void updateFuelStatus()
        {
            mainView.fuelStatusLabel = "| Diesel " + fuelController.fuelList[0].quantity + " | Octane92 " +
               fuelController.fuelList[1].quantity + " | Octane95 " + fuelController.fuelList[2].quantity + " | Octane98 " +
               fuelController.fuelList[3].quantity + " | Gas " + fuelController.fuelList[4].quantity;
            foreach (Fuel f in fuelController.fuelList)
                mainView.addToDataGridView(f.type.ToString(), "Updated: " + f.quantity);
        }

        public void placeVehicles()
        {
            List<Vehicle> vehiclesToPlace = new List<Vehicle>(vehicleList);
            int counter = 0;
            for (int j = 0; j < vehicleList.Count; j++)
            {                
                Vehicle v = vehicleList[j];
                if (v is Tank || v is HorseDrawnCarriage || v is Scooter)
                {
                    if (road.lanes[0].vehicle == null)
                    {
                        road.lanes[0].vehicle = v;
                        mainView.addToDataGridView(v.name, "is placed to 1 lane");
                        counter++;
                    }
                    else
                    {
                        if (road.lanes[4].vehicle == null)
                        {
                            road.lanes[4].vehicle = v;
                            mainView.addToDataGridView(v.name, "is placed to 5 lane");
                        }
                        else
                        {
                            mainView.addToDataGridView(v.name, "is not placed because all side lanes are busy");
                        }
                    }
                    vehiclesToPlace.Remove(v);
                }
            }            
            foreach (TrafficLane tl in road.lanes)
            {
                counter++;
                if (tl.vehicle == null && vehiclesToPlace.Count != 0)
                {
                    tl.vehicle = vehiclesToPlace[0];
                    mainView.addToDataGridView(tl.vehicle.name, "is placed to "+counter+" lane");
                    vehiclesToPlace.RemoveAt(0);
                }
            }
        }
        public void calculateMaxDistance()
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.driverAge < Road.DRIVER_MIN_AGE)
                    v.maxDistance = 0;
                else if (v is Trolleybus || v is Trum)
                    v.maxDistance = Trolleybus.MAX_DISTANCE;
                else v.maxDistance = (v is MotorizedVehicle) ?
                        (((Double)((MotorizedVehicle)v).consumption) == 0 ? 0 :
                    (int)(HUNDRED_KM * ((Double)((MotorizedVehicle)v).Fuel.quantity) / ((Double)((MotorizedVehicle)v).consumption)))
                    : (v is HorseDrawnCarriage) ? HorseDrawnCarriage.MAX_DISTANCE
                    : (v is Bicycle) ? Bicycle.MAX_DISTANCE : Scooter.MAX_DISTANCE;
                if (v.maxDistance >= 501)
                {
                    v.maxDistance = 501;
                }
                Console.WriteLine(v.name + " MaxDistance=" + v.maxDistance);
            }
        }
        public void calculateAcceleration()
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.driverAge < 18)
                {
                    v.Acceleration = 0;
                }
                else
                {
                    if (v.maxDistance != 0)
                    {
                        v.Acceleration = (double)(v.maxSpeed - v.startSpeed) * (v.maxSpeed + v.startSpeed) / v.maxDistance;
                    }
                    else
                    {
                        v.Acceleration = (double)(v.maxSpeed - v.startSpeed) * (v.maxSpeed + v.startSpeed) / 50;
                    }
                }
                Console.WriteLine(v.name + " Acceleration=" + v.Acceleration);
            }
        }
        public void startSimulation()
        {
            ThreadPool.QueueUserWorkItem(delegate { simulate(); });

        }        
        private void simulate()
        {
            running = true; 
            List<TrafficLane> runLanes = new List<TrafficLane>(road.lanes);
            calculateTimeCoefficient(runLanes);
            int vehiclesOnRoad = road.checkNonEmptyLine();
            int stoppedVehicles = 0;
            while ((runLanes.Count != 0) && (running==true) &&(vehiclesOnRoad > stoppedVehicles))
            {
                changeVehicleSpeed(runLanes);
                foreach (TrafficLane tl in road.lanes)
                {
                    if ((tl.vehicle != null) && (runLanes.Contains(tl)))
                    {
                        Thread.Sleep((int)(Road.UPDATE_DELAY_MSEC));
                        if (tl.position+tl.vehicle.curSpeed*Road.timeCoefficient >= 500 || tl.vehicle.maxDistance <= tl.position) {
                            runLanes.Remove(tl);
                            tl.vehicle.curSpeed = 0;
                            stoppedVehicles++;                            
                        }
                        else if (runLanes.Contains(tl))
                        {
                            tl.position = (double)(tl.position + (double)tl.vehicle.curSpeed*Road.timeCoefficient);
                        }
                        //Console.WriteLine(tl.vehicle.curSpeed + " CurrentVelocity");
                    }
                }
            }           
            running = false;            
        }

        public void stopSimulation()
        {
            running = false;            
            foreach (TrafficLane tl in road.lanes)
            {
                if (tl.vehicle != null)
                {
                    tl.vehicle.curSpeed = tl.vehicle.startSpeed;
                }
            }
        }
        
        private void calculateTimeCoefficient(List<TrafficLane> lanes)
        {
            int avgSpeed = 0;
            int notEmptyLanes = 0;
            foreach (TrafficLane tl in lanes)
                if (tl.vehicle != null)
                {
                    avgSpeed += tl.vehicle.maxSpeed;
                    notEmptyLanes++;
                }
            avgSpeed = avgSpeed / lanes.Count;
            if ((Road.TIME_AVERAGE_SEC != 0) && (avgSpeed!=0))
            {
                Road.timeCoefficient = (double)(2 * notEmptyLanes * Road.UPDATE_DELAY_MSEC * Road.ROAD_LENGTH_KM / avgSpeed) / (3600 * Road.TIME_AVERAGE_SEC);
            }
            Console.WriteLine("TimeCoeff" + Road.timeCoefficient);
        }

        private void changeVehicleSpeed(List<TrafficLane> lanes)
        {
            foreach (TrafficLane tl in lanes)
            {
                if ((tl.vehicle != null) && (tl.position<tl.vehicle.maxDistance))
                 {
                    if (tl.vehicle.curSpeed == 0)
                    {
                        tl.vehicle.curSpeed = tl.vehicle.startSpeed;
                    }
                    else
                    {
                        if (tl.vehicle.curSpeed < tl.vehicle.maxSpeed)
                        {
                            tl.vehicle.curSpeed = (tl.vehicle.curSpeed + tl.vehicle.Acceleration*Road.timeCoefficient);
                        }
                        else
                        {
                            tl.vehicle.curSpeed = tl.vehicle.maxSpeed;
                        }
                    }                   
                }                              
            }
        }
    }
}
