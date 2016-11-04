using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportSimulatorGUI
{
    public partial class MainWindow : Form
    {
        private FuelControlWindow fuelControlWindow = new FuelControlWindow();
        private VehicleControlWindow vehicleControlWindow = new VehicleControlWindow();
        public MainWindow()
        {
            InitializeComponent();
            AddOwnedForm(fuelControlWindow);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            fuelControlWindow.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            vehicleControlWindow.ShowDialog();
        }
    }
}
