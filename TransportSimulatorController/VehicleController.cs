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

        public bool addVehicle()
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
            vehicleList.Add(newVehicle);
            Fuel fuel = new Fuel(FuelType.ELECTRICITY,-1);
            if ((newVehicle is Bike) || (newVehicle is Car)|| (newVehicle is Tank)|| (newVehicle is Truck)) {
                Fuel availableFuel = fuelController.fuelList.FindLast(x => x.type == vehicleView.fuelType);
                int availableFuelQuantity = availableFuel.quantity;
                if (availableFuelQuantity <= vehicleView.fuelQuantity)
                    return false;
                ((MotorizedVehicle)newVehicle).consumption = vehicleView.consumption;
                ((MotorizedVehicle)newVehicle).Fuel.type = vehicleView.fuelType;
                ((MotorizedVehicle)newVehicle).Fuel.quantity = vehicleView.fuelQuantity;
                availableFuel.quantity -= vehicleView.fuelQuantity;
            }
            else
            Console.WriteLine(newVehicle is MotorizedVehicle);
            return true;
        }
    }
}
