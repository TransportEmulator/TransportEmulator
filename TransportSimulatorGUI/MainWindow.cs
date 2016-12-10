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
        public void showPlacement(Road road) {
            List<PictureBox> pb = new List<PictureBox>();
            pb.Add(vehiclePicture1);
            pb.Add(vehiclePicture2);
            pb.Add(vehiclePicture3);
            pb.Add(vehiclePicture4);
            pb.Add(vehiclePicture5);
            for(int i =0; i< road.lanes.Count; i++) {
                if (road.lanes[i].vehicle != null)
                {
                    Console.WriteLine("Car "+road.lanes[i].vehicle);
                    switch (road.lanes[i].vehicle.GetType().Name)
                    {
                        case "Trolleybus": pb[i].Image = images[0]; break;
                        case "Car": pb[i].Image = images[1];  break;
                        case "Truck": pb[i].Image = images[2];break;
                        case "Bus": pb[i].Image = images[3];  break;
                        case "Bicycle": pb[i].Image = images[4];  break;
                        case "Scooter": pb[i].Image = images[5]; break;
                        case "Bike": pb[i].Image = images[6];  break;
                        case "Tank": pb[i].Image = images[7];  break;
                        case "Trum:": pb[i].Image = images[8]; break;
                        case "HorseDrawnCarriage": pb[i].Image = images[9]; break;
                        default: pb[i].Image = images[9];  break;
                    }
                    pb[i].Visible = true;
                   }
                }
            vehiclePicture1 = pb[0];
            vehiclePicture2 = pb[1];
            vehiclePicture3 = pb[2];
            vehiclePicture4 = pb[3];
            vehiclePicture5 = pb[4];
        }
        string IMainActions.fuelStatusLabel
        {
            get{ return fuelStatusLabel.Text; }
            set{ fuelStatusLabel.Text = value; }
        }
        public MainWindow()
        {          

            InitializeComponent();
            images[0] = global::TransportSimulatorGUI.Properties.Resources.trolleybusPicture;
            images[1] = global::TransportSimulatorGUI.Properties.Resources.carPicture;
            images[2] = global::TransportSimulatorGUI.Properties.Resources.truckPicture;
            images[3] = global::TransportSimulatorGUI.Properties.Resources.busPicture;
            images[4] = global::TransportSimulatorGUI.Properties.Resources.bikePicture;
            images[5] = global::TransportSimulatorGUI.Properties.Resources.scooterPicture;
            images[6] = global::TransportSimulatorGUI.Properties.Resources.bikePicture;
            images[7] = global::TransportSimulatorGUI.Properties.Resources.tankPicture;
            images[8] = global::TransportSimulatorGUI.Properties.Resources.TramVehicleWhite;
            images[9] = global::TransportSimulatorGUI.Properties.Resources.wagonPicture;
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
            mainController.placeVehicles();
            showPlacement(mainController.road);
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

        private void vehicle_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vehilcePicture1_Click(object sender, EventArgs e)
        {

        }
    }
}
