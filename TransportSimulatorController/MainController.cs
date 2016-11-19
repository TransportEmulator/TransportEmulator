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
        public MainController(IMainActions mainView) {
            this.mainView = mainView;
            mainView.setController(this);
            fuelController = new FuelController(mainView.getFuelView());
        }
       
    }
}
