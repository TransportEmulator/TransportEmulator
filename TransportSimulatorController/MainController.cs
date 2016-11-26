using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public class MainController
    {
        IMainActions mainView;
        FuelController fuelController;
        VehicleController vehicleController;
        public MainController(IMainActions mainView) {
            this.mainView = mainView;
            mainView.setController(this);
            fuelController = new FuelController(mainView.getFuelView());
            vehicleController = new VehicleController(mainView.getVehicleControlView(),fuelController);
            updateFuelStatus();
        }
        public void updateFuelStatus() {
            mainView.fuelStatusLabel = "| Diesel " + fuelController.fuelList[0].quantity + " | Octane92 " +
               fuelController.fuelList[1].quantity + " | Octane95 " + fuelController.fuelList[2].quantity + " | Octane98 " +
               fuelController.fuelList[3].quantity + " | Gas " + fuelController.fuelList[4].quantity;
        }
       
    }
}
