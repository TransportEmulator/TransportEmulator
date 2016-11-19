using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public class FuelController
    {
        private int DEFAULT_FUEL_QUANITY_LITERS = 20;
        IFuelView fuelView;
        private List<Fuel> fuelList = new List<Fuel>();
        public FuelController(IFuelView fuelView) {
            fuelList.Add(new Fuel(FuelType.DIESEL, DEFAULT_FUEL_QUANITY_LITERS));
            fuelList.Add(new Fuel(FuelType.OCTANE_92, DEFAULT_FUEL_QUANITY_LITERS));
            fuelList.Add(new Fuel(FuelType.OCTANE_95, DEFAULT_FUEL_QUANITY_LITERS));
            fuelList.Add(new Fuel(FuelType.OCTANE_98, DEFAULT_FUEL_QUANITY_LITERS));
            fuelList.Add(new Fuel(FuelType.GAS, DEFAULT_FUEL_QUANITY_LITERS));
            fuelView.gasQuantity = fuelView.dieselQuantity = fuelView.octane95Quantity = fuelView.octane92Quantity
                = fuelView.octane98Quantity = DEFAULT_FUEL_QUANITY_LITERS;
            this.fuelView = fuelView;
            fuelView.setController(this);
        }
        public void updateFuelAmount() {
            fuelList[0].quantity = fuelView.dieselQuantity;
            fuelList[1].quantity = fuelView.octane92Quantity;
            fuelList[2].quantity = fuelView.octane95Quantity;
            fuelList[3].quantity = fuelView.octane98Quantity;
            fuelList[4].quantity = fuelView.gasQuantity;
        }
       
    }
}
