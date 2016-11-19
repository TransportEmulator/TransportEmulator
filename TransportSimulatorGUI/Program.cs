using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportSimulatorController;

namespace TransportSimulatorGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainWindow mainWindow = new MainWindow();
            MainController mainController = new MainController(mainWindow);
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(mainWindow);
            mainWindow.ShowDialog();
        }
    }
}
