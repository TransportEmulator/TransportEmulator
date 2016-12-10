using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public class MainController
    {
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
        }
        public void updateFuelStatus() {
            mainView.fuelStatusLabel = "| Diesel " + fuelController.fuelList[0].quantity + " | Octane92 " +
               fuelController.fuelList[1].quantity + " | Octane95 " + fuelController.fuelList[2].quantity + " | Octane98 " +
               fuelController.fuelList[3].quantity + " | Gas " + fuelController.fuelList[4].quantity;
        }

        public void placeVehicles()
        {
            List<Vehicle> vehiclesToPlace = new List<Vehicle>(vehicleList);
            Console.WriteLine("Size="+road.lanes.Count);
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
                if (tl.vehicle == null && vehiclesToPlace.Count!=0) {
                    tl.vehicle = vehiclesToPlace[0];
                    vehiclesToPlace.RemoveAt(0);
                }
            }
            /*foreach (TrafficLane tl in road.lanes) {
                Console.WriteLine("Lane "+tl.vehicle);
            }*/
            
            }

    }
}
