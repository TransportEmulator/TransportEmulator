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
        private static int HUNDRET_KM = 100;
        private List<Vehicle> vehicleList = new List<Vehicle>();
        public Road road;
        IMainActions mainView;
        FuelController fuelController;
        VehicleController vehicleController;
        public MainController(IMainActions mainView) {
            road = new Road();
            this.mainView = mainView;
            mainView.setController(this);
            fuelController = new FuelController(mainView.getFuelView());
            vehicleController = new VehicleController(mainView.getVehicleControlView(),fuelController,vehicleList);
            updateFuelStatus();
            startDelay = new System.Timers.Timer();
            startDelay.Interval = 1000;
            startDelay.Elapsed += startDelay_Elapsed;         
        }
        private Boolean start = false;
        private void startDelay_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            start = true;
        }
        public void updateFuelStatus() {
            mainView.fuelStatusLabel = "| Diesel " + fuelController.fuelList[0].quantity + " | Octane92 " +
               fuelController.fuelList[1].quantity + " | Octane95 " + fuelController.fuelList[2].quantity + " | Octane98 " +
               fuelController.fuelList[3].quantity + " | Gas " + fuelController.fuelList[4].quantity;
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
                        road.lanes[0].vehicle = v;                  
                    else if (road.lanes[4].vehicle == null)
                        road.lanes[4].vehicle = v;                                        
                    vehiclesToPlace.Remove(v);
                }
            }
            foreach (TrafficLane tl in road.lanes) {
                if (tl.vehicle == null && vehiclesToPlace.Count != 0)
                {
                    tl.vehicle = vehiclesToPlace[0];
                    vehiclesToPlace.RemoveAt(0);
                }                
            }
            /*foreach (TrafficLane tl in road.lanes) {
                Console.WriteLine("Lane "+tl.vehicle);
            }*/

        }

        public void calculateMaxDistance()
        {
            int maxDistance = 0;
            foreach (Vehicle v in vehicleList) {
                if (v.driverAge < 18)
                    v.maxDistance = 0;
                else if (v is Trolleybus || v is Trum)
                    v.maxDistance = 501;
                else v.maxDistance = (v is MotorizedVehicle) ?
                        (((Double)((MotorizedVehicle)v).consumption) == 0 ? 0 :
                    (int)(HUNDRET_KM * ((Double)((MotorizedVehicle)v).Fuel.quantity) / ((Double)((MotorizedVehicle)v).consumption)))
                    : (v is HorseDrawnCarriage) ? 250
                    : (v is Bicycle) ? 30:10;
                Console.WriteLine(v.name+" MaxDistance="+v.maxDistance);
            }
        }

        public void startSimulation()
        {
            ThreadPool.QueueUserWorkItem(delegate { simulate(); });
           
        }
        private void simulate(TrafficLane tl)
        {
            while (!start) { }
            for (int i = 0; i < 500; i++) {
                Thread.Sleep(8);
                tl.position++;
                Thread.Sleep(0);
                Thread.Yield();
            }
        }
        private void simulate() {
            startDelay.Start();
           /* for (int i = 0; i < road.lanes.Count; i++)
                if (road.lanes[i] == null || road.lanes[i].vehicle == null || road.lanes[i].vehicle.Equals(""))
                    road.lanes.RemoveAt(i);
            foreach (TrafficLane tl in road.lanes)
                Console.WriteLine("> "+tl+"  > '"+tl.vehicle+"'");*/
           // foreach (TrafficLane tl in road.lanes)
           //     ThreadPool.QueueUserWorkItem(delegate { simulate(tl); });
                int stopCounter = 5;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                List<TrafficLane> runLanes = new List<TrafficLane>(road.lanes);
                Random random = new Random();
                while (runLanes.Count!=0)
                {
                    changeVehicleSpeed(road.lanes);
                    int minSpeed = getMinSpeedOnRoad(road.lanes);
                    foreach (TrafficLane tl in road.lanes)
                    {
                        if (tl.vehicle != null)
                        {
                            
                             Thread.Sleep(10);
                             if (tl.position >= 500 || tl.vehicle.maxDistance <= tl.position)
                                runLanes.Remove(tl);
                            else if (runLanes.Contains(tl)) tl.position += tl.vehicle.curSpeed/minSpeed;                   
                    }
                    }
                }
               sw.Stop();
            }

        private int getMinSpeedOnRoad(List<TrafficLane> lanes)
        {
            int minSpeed = 5000;
            foreach (TrafficLane tl in lanes)
                minSpeed = (tl.vehicle.curSpeed < minSpeed) ? tl.vehicle.curSpeed : minSpeed;
            return minSpeed;
        }

        private void changeVehicleSpeed(List<TrafficLane> lanes)
        {
            Random random = new Random();
            foreach (TrafficLane tl in lanes)
                if (tl.vehicle != null)
                {
                    if (tl.position > tl.vehicle.maxDistance / 2)
                        tl.vehicle.curSpeed = tl.vehicle.maxSpeed;
                    else
                        tl.vehicle.curSpeed = tl.vehicle.maxSpeed - random.Next(1, tl.vehicle.maxSpeed);
                }
        }
    }
}
