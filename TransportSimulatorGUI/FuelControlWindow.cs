using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportSimulatorController;


namespace TransportSimulatorGUI
{
    public partial class FuelControlWindow : Form,IFuelView
    {
        private FuelController fuelController;

        public int dieselQuantity
        {
            get{ return dieselTrackBar.Value;}
            set { dieselTrackBar.Value= value;
                dieselAmountLabel.Text = value.ToString(); 
            }
        }

        public int octane92Quantity
        {
            get{ return ron92TrackBar.Value; }
            set{ ron92TrackBar.Value = value;
               ron92AmountLabel.Text = value.ToString();
            }
        }

        public int octane95Quantity
        {
            get{ return ron95TrackBar.Value; }
            set{ ron95TrackBar.Value = value;
                ron95AmountLabel.Text = value.ToString();
            }
        }

        public int octane98Quantity
        {
            get { return ron98TrackBar.Value; }
            set{ ron98TrackBar.Value = value;
                ron98AmountLabel.Text = value.ToString();
            }
        }

        public int gasQuantity
        {  get{ return gasTrackBar.Value; }
            set{gasTrackBar.Value = value;
                gasAmountLabel.Text = value.ToString(); }
        }

        public void SetController(FuelController controller)
        {
            this.fuelController = controller;
        }
        public FuelControlWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dieselTrackBar_Scroll(object sender, EventArgs e)
        {
            dieselAmountLabel.Text = dieselTrackBar.Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ron92AmountLabel.Text = ron92TrackBar.Value.ToString();
        }

        private void ron95TrackBar_Scroll(object sender, EventArgs e)
        {
            ron95AmountLabel.Text = ron95TrackBar.Value.ToString();
        }

        private void ron98TrackBar_Scroll(object sender, EventArgs e)
        {
            ron98AmountLabel.Text = ron98TrackBar.Value.ToString();
        }

        private void gasTrackBar_Scroll(object sender, EventArgs e)
        {
            gasAmountLabel.Text =gasTrackBar.Value.ToString();
        }

        private void updateFuelButton_Click(object sender, EventArgs e)
        {
            this.fuelController.updateFuelAmount();
            this.Close();
        }

        public void setController(FuelController fuelController)
        {
            this.fuelController = fuelController;
        }

        private void dieselAmountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
