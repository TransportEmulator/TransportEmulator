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
            /* for (int i = 0; i < vehicleList.Count; i++)
                 if (vehicleList[i] == null)
                     vehicleList.RemoveAt(i);*/
            List<Vehicle> vehiclesToPlace = new List<Vehicle>(vehicleList);
            for (int j = 0; j < vehicleList.Count; j++)
            {
                Vehicle v = vehicleList[j];
                if (v is Tank || v is HorseDrawnCarriage || v is Scooter)
                {
                    if (road.lanes[0].vehicle == null)
                    {
                        road.lanes[0].vehicle = v;
                        mainView.addToDataGridView("ID=" + v.ID + ", " + v.name, "is placed to 1 lane");
                    }
                    else
                    {
                        if (road.lanes[4].vehicle == null)
                        {
                            road.lanes[4].vehicle = v;
                            mainView.addToDataGridView("ID=" + v.ID + ", " + v.name, "is placed to 5 lane");
                        }
                        else
                        {
                            mainView.addToDataGridView("ID=" + v.ID + ", " + v.name, "is not placed because all side lanes are busy");
                        }
                    }
                    vehiclesToPlace.Remove(v);
                }
            }
            int counter = 0;
            foreach (TrafficLane tl in road.lanes)
            {
                counter++;
                if (tl.vehicle == null && vehiclesToPlace.Count != 0)
                {
                    tl.vehicle = vehiclesToPlace[0];
                    mainView.addToDataGridView("ID=" + tl.vehicle.ID + ", " + tl.vehicle.name, "is placed to "+counter+" lane");
                    vehiclesToPlace.RemoveAt(0);
                }
            }
        }
        public void calculateMaxDistance()
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.driverAge < 18)
                    v.maxDistance = 0;
                else if (v is Trolleybus || v is Trum)
                    v.maxDistance = 501;
                else v.maxDistance = (v is MotorizedVehicle) ?
                        (((Double)((MotorizedVehicle)v).consumption) == 0 ? 0 :
                    (int)(HUNDRED_KM * ((Double)((MotorizedVehicle)v).Fuel.quantity) / ((Double)((MotorizedVehicle)v).consumption)))
                    : (v is HorseDrawnCarriage) ? 250
                    : (v is Bicycle) ? 30 : 10;
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
        /*private void simulate(TrafficLane tl)
        {
            while (!start) { }
            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(8);
                tl.position += tl.vehicle.curSpeed / 300;
                Thread.Sleep(0);
                Thread.Yield();
            }
        }*/
        private void simulate()
        {
            mainView.addToDataGridView("Main Controller", "Simulation started!");
            running = true;
            startDelay.Start();
            sw.Start();
            List<TrafficLane> runLanes = new List<TrafficLane>(road.lanes);
            calculateTimeCoefficient(runLanes);
            int vehiclesOnRoad = road.checkNonEmptyLine();
            int stoppedVehicles = 0;
            while ((runLanes.Count != 0) && (running==true) &&(vehiclesOnRoad > stoppedVehicles))
            {
                changeVehicleSpeed(runLanes);
                foreach (TrafficLane tl in road.lanes)
                {
                    if (tl.vehicle != null)
                    {
                        Thread.Sleep((int)(Road.UPDATE_DELAY_MSEC));
                        if (tl.position+tl.vehicle.curSpeed*Road.timeCoefficient >= 500 || tl.vehicle.maxDistance <= tl.position) {
                            mainView.addToDataGridView("ID=" + tl.vehicle.ID + ", " + tl.vehicle.name, "Finished! Current location = " + (int)(Math.Ceiling(tl.position)));
                            runLanes.Remove(tl);
                            stoppedVehicles++;
                        }
                        else if (runLanes.Contains(tl))
                        {
                            tl.position = (double)(tl.position + (double)tl.vehicle.curSpeed*Road.timeCoefficient);
                        }
                        if (tl.position - tl.vehicle.lastContact >= 50)
                        {
                            mainView.addToDataGridView("ID=" + tl.vehicle.ID + ", " + tl.vehicle.name, "Current location = " + (int)(tl.position));
                            tl.vehicle.lastContact = (int)tl.position;
                        }
                        //Console.WriteLine(tl.vehicle.name + " CurrentPos=" + tl.position);
                    }
                }
            }
            sw.Stop();
            running = false;
            mainView.addToDataGridView("Main Controller", "Simulation finished!");
        }

        public void stopSimulation()
        {
            sw.Stop();
            if (running == true)
            {
                mainView.addToDataGridView("Main Controller", "Simulation stopped!");
            }
            running = false;            
            foreach (TrafficLane tl in road.lanes)
            {
                if (tl.vehicle != null)
                {
                    tl.vehicle.curSpeed = tl.vehicle.startSpeed;
                }
            }
        }

        /*private int getMinSpeedOnRoad(List<TrafficLane> lanes)
        {
            int minSpeed = 5000;
            foreach (TrafficLane tl in lanes)
                if (tl.vehicle != null)
                    minSpeed = (tl.vehicle.curSpeed < minSpeed) ? tl.vehicle.curSpeed : minSpeed;
            return minSpeed;
        }*/

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
            Road.timeCoefficient = (double)(2 * notEmptyLanes * Road.UPDATE_DELAY_MSEC * Road.ROAD_LENGTH_KM / avgSpeed) / (3600 * Road.TIME_AVERAGE_SEC);
            Console.WriteLine("TimeCoeff" + Road.timeCoefficient);
        }

        private void changeVehicleSpeed(List<TrafficLane> lanes)
        {
            foreach (TrafficLane tl in lanes)
            {
                if (tl.vehicle != null)
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
