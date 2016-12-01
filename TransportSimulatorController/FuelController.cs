using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportSimulatorLogger;

namespace TransportSimulatorController
{
    public class FuelController 
    {
        private int DEFAULT_FUEL_QUANITY_LITERS = 20;
        IFuelView fuelView;
        private List<Fuel> _fuelList = new List<Fuel>();
        public List<Fuel> fuelList { get { return _fuelList; } set { _fuelList = value; } }  
        public FuelController(IFuelView fuelView) {
            _fuelList.Add(new Fuel(FuelType.DIESEL, DEFAULT_FUEL_QUANITY_LITERS));
            _fuelList.Add(new Fuel(FuelType.OCTANE_92, DEFAULT_FUEL_QUANITY_LITERS));
            _fuelList.Add(new Fuel(FuelType.OCTANE_95, DEFAULT_FUEL_QUANITY_LITERS));
            _fuelList.Add(new Fuel(FuelType.OCTANE_98, DEFAULT_FUEL_QUANITY_LITERS));
            _fuelList.Add(new Fuel(FuelType.GAS, DEFAULT_FUEL_QUANITY_LITERS));
            fuelView.gasQuantity = fuelView.dieselQuantity = fuelView.octane95Quantity = fuelView.octane92Quantity
                = fuelView.octane98Quantity = DEFAULT_FUEL_QUANITY_LITERS;
            this.fuelView = fuelView;
            fuelView.setController(this);
        }
        public void updateFuelAmount() {
            _fuelList[0].quantity = fuelView.dieselQuantity;
            _fuelList[1].quantity = fuelView.octane92Quantity;
            _fuelList[2].quantity = fuelView.octane95Quantity;
            _fuelList[3].quantity = fuelView.octane98Quantity;
            _fuelList[4].quantity = fuelView.gasQuantity;
            StringBuilder logMessage = new StringBuilder();
            foreach (Fuel f in _fuelList)
                LogHelper.Log(LogTarget.File,f.type.ToString(),"Update: total quantity "+f.quantity+"liters");
        }
       
    }
}
