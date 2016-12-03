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
    public partial class MainWindow : Form,IMainActions
    {
        MainController mainController;

        private FuelControlWindow fuelControlWindow = new FuelControlWindow();
        private InformationWindow informationWindow = new InformationWindow();
        private VehicleControlWindow vehicleControlWindow = new VehicleControlWindow();
        private SelectVehicleWindow selectVehicleWindow = new SelectVehicleWindow();
         string IMainActions.fuelStatusLabel
        {
            get{ return fuelStatusLabel.Text; }
            set{ fuelStatusLabel.Text = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            AddOwnedForm(fuelControlWindow);
            AddOwnedForm(informationWindow);
            AddOwnedForm(vehicleControlWindow);
            AddOwnedForm(selectVehicleWindow);
           

        }
        public void setController(MainController mainController)
        {
            this.mainController = mainController;
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
            mainController.updateFuelStatus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //lane_1.Visible = true;
            //vehicle_1.Left = vehicle_1.Left + lane_1.Width / 500;
            //System.Threading.Thread.Sleep(1);
            //vehicle_1.BackgroundImage = Properties.Resources.TrolleybusVehicleWhite;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            vehicleControlWindow.ShowDialog();
            mainController.updateFuelStatus();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            informationWindow.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            informationWindow.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            selectVehicleWindow.ShowDialog();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel xlsx file (*.xlsx)|*.xlsx|Excel xls file (*.xls)|*.xls";
            saveFileDialog1.ShowDialog();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word doc file (*.docx)|*.docx|Word docx file(*.doc)|*.doc";
            saveFileDialog1.ShowDialog();
        }

        public IFuelView getFuelView()
        {
            return fuelControlWindow;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public IVehicleControlView getVehicleControlView()
        {
            return vehicleControlWindow;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            /*Random RandomNumber1 = new Random();
            int x = RandomNumber1.Next(0, 3);
            if (x == 0)
                lane_1.BackgroundImage = (Image)null;
            if (x == 1)
                lane_1.BackgroundImage = (Image)Properties.Resources.TramTransparent013;
            if (x == 2)
                lane_1.BackgroundImage = (Image)Properties.Resources.TrolleyTransparent;*/
        }
    }
}
