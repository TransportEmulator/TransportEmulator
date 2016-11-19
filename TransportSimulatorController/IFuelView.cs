using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public interface IFuelView
    {
        void setController(FuelController fuelController);
        int dieselQuantity { get; set; }
        int octane92Quantity { get; set; }
        int octane95Quantity { get; set;}
        int octane98Quantity { get; set;}
        int gasQuantity { get; set; }
    }
}
