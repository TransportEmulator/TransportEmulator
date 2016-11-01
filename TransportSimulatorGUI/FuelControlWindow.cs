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
    public partial class FuelControlWindow : Form
    {
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
    }
}
