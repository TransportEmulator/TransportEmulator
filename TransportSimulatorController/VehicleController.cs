using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public class VehicleController
    {
        FuelController fuelController;
        IVehicleControlView vehicleView;
        private List<Vehicle> vehicleList = new List<Vehicle>();
        public VehicleController(IVehicleControlView vehicleView,FuelController fuelController) {
            this.vehicleView = vehicleView;
            vehicleView.setController(this);
            this.fuelController = fuelController;
        }

        public Vehicle addVehicle()
        {
            String type = vehicleView.chosenVehicle.Substring(0, vehicleView.chosenVehicle.Length - 3);
            type = char.ToUpper(type[0]) + type.Substring(1);
            Trolleybus t = new Trolleybus();
            Vehicle newVehicle =(Vehicle) Activator.CreateInstance(
                Type.GetType(type+ ",TransportEmulatorLib"));
            newVehicle.maxSpeed = vehicleView.maxSpeed;
            newVehicle.name = vehicleView.name;
            newVehicle.weight = vehicleView.weight;
            newVehicle.driverAge = vehicleView.driverAge;
            
            Fuel fuel = new Fuel(FuelType.ELECTRICITY,-1);
            if ((newVehicle is Bike) || (newVehicle is Car) || (newVehicle is Tank) || (newVehicle is Truck))
            {
                Console.WriteLine("NEW VEHICLE!");
                Fuel availableFuel = fuelController.fuelList.FindLast(x => x.type == vehicleView.fuelType);
                int availableFuelQuantity = availableFuel.quantity;
                if (availableFuelQuantity <= vehicleView.fuelQuantity)
                    return null;
                ((MotorizedVehicle)newVehicle).consumption = vehicleView.consumption;
                ((MotorizedVehicle)newVehicle).Fuel = new Fuel(vehicleView.fuelType, vehicleView.fuelQuantity);
               //((MotorizedVehicle)newVehicle).Fuel.type = vehicleView.fuelType;
               // ((MotorizedVehicle)newVehicle).Fuel.quantity = vehicleView.fuelQuantity;
                fuelController.fuelList[fuelController.fuelList.IndexOf(availableFuel)].quantity -= vehicleView.fuelQuantity;

            }
            else if ((newVehicle is Trolleybus) || (newVehicle is Trum))
            {
                ((MotorizedVehicle)newVehicle).Fuel = new Fuel(FuelType.ELECTRICITY, -1);
            }
            vehicleList.Add(newVehicle);
            return newVehicle;
        }
    }
}
