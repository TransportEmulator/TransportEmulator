using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public interface IVehicleControlView
    {
        int consumption { get; }
        int fuelQuantity { get; }
        FuelType fuelType { get; }
        string chosenVehicle { get; }
        string name { get; }
        int maxSpeed { get; }
        int driverAge { get; }
        int weight { get; }
       void setController(VehicleController vehicleController);
    }
}
