using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulatorController
{
    public interface IMainActions
    {
        void addToDataGridView(string source, string message);
        void setController(MainController mainController);
        IFuelView getFuelView();
        IVehicleControlView getVehicleControlView();
        string fuelStatusLabel { get; set; }
    }
}
