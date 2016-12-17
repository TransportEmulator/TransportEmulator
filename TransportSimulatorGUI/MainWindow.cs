using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using TransportSimulatorController;
using System.Diagnostics;

namespace TransportSimulatorGUI
{
    public partial class MainWindow : Form,IMainActions
    {
        MainController mainController;
        Timer simulationTimer = new Timer();
        Stopwatch sw = new Stopwatch();
        DateTime startTime;
        bool runningFlag;
        private FuelControlWindow fuelControlWindow = new FuelControlWindow();
        private InformationWindow informationWindow = new InformationWindow();
        private VehicleControlWindow vehicleControlWindow = new VehicleControlWindow();
        private void reinitializePictureBox() {
            this.vehiclePicture1.Location = new System.Drawing.Point(0, 3);
            this.vehiclePicture2.Location = new System.Drawing.Point(0, 3);
            this.vehiclePicture3.Location = new System.Drawing.Point(0, 3);
            this.vehiclePicture4.Location = new System.Drawing.Point(0, 3);
            this.vehiclePicture5.Location = new System.Drawing.Point(0, 3);     
        }
        public void stopSimulation()
        {
            runningFlag = false;
        }
        public void showPlacement(Road road) {
            reinitializePictureBox();
            List<PictureBox> pb = new List<PictureBox>();
            List<Panel> lanes = new List<Panel>();
            pb.Add(vehiclePicture1);
            pb.Add(vehiclePicture2);
            pb.Add(vehiclePicture3);
            pb.Add(vehiclePicture4);
            pb.Add(vehiclePicture5);
            lanes.Add(lane_1);
            lanes.Add(lane_2);
            lanes.Add(lane_3);
            lanes.Add(lane_4);
            lanes.Add(lane_5);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, lane_1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, vehiclePicture1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, lane_2, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, vehiclePicture2, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, lane_3, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, vehiclePicture3, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, lane_4, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, vehiclePicture4, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, lane_5, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, vehiclePicture5, new object[] { true });
            for (int i =0; i< road.lanes.Count; i++) {
                if (road.lanes[i].vehicle != null)
                {
                    Console.WriteLine("Car "+road.lanes[i].vehicle);
                    pb[i].Image = images[road.lanes[i].vehicle.ID];                    
                    pb[i].Visible = true;
                }
                else
                {
                    Console.WriteLine("Empty lane " + road.lanes[i].vehicle);
                    pb[i].Image = null;
                    pb[i].Visible = true;
                }
                if (road.lanes[i].hasRails)
                {
                    lanes[i].BackgroundImage = global::TransportSimulatorGUI.Properties.Resources.TramTransparent013;
                }
                else
                {
                    if (road.lanes[i].hasWire)
                    {
                        lanes[i].BackgroundImage = global::TransportSimulatorGUI.Properties.Resources.TrolleyRoadTransparent1;
                    }
                    else
                    {
                        lanes[i].BackgroundImage = null;
                    }
                }
            }           
        }
        string IMainActions.fuelStatusLabel
        {
            get{ return fuelStatusLabel.Text; }
            set{ fuelStatusLabel.Text = value; }
        }

        public ComboBox filteringComb
        {
            get
            {
                return comboBox1;
            }

            set
            {
                comboBox1 = value;
            }
        }

        public MainWindow()
        {          
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            simulationTimer.Tick += new EventHandler(simulationTimer_Tick);            
            images[0] = global::TransportSimulatorGUI.Properties.Resources.trolleybusPicture;
            images[1] = global::TransportSimulatorGUI.Properties.Resources.carPicture;
            images[2] = global::TransportSimulatorGUI.Properties.Resources.truckPic;
            images[3] = global::TransportSimulatorGUI.Properties.Resources.busPicture;
            images[4] = global::TransportSimulatorGUI.Properties.Resources.bikePicture;
            images[5] = global::TransportSimulatorGUI.Properties.Resources.scooterPicture;
            images[6] = global::TransportSimulatorGUI.Properties.Resources.bikePicture;
            images[7] = global::TransportSimulatorGUI.Properties.Resources.tankPicture;
            images[8] = global::TransportSimulatorGUI.Properties.Resources.tramPicture;
            images[9] = global::TransportSimulatorGUI.Properties.Resources.wagonPicture;
            AddOwnedForm(fuelControlWindow);
            AddOwnedForm(informationWindow);
            AddOwnedForm(vehicleControlWindow);
            Road.graphicsWidth = lane_5.Width = lane_4.Width = lane_3.Width = lane_2.Width = lane_1.Width;
            runningFlag = false;
        }
        private void simulationTimer_Tick(Object sender, EventArgs e) {
            this.UpdatePositions();
            //toolStripStatusLabel1.Text = "Simulation time: "+DateTime.Now.Subtract(startTime).ToString("ss");  
            toolStripStatusLabel1.Text = "Simulation time: " + sw.ElapsedMilliseconds+" ms ";
        }
        List<int> positionToPixels(List<double> positions) {
            List<int> pixels = new List<int>();
            foreach (int pos in positions)
                pixels.Add((int)(Math.Round((Road.distanceCoefficient * pos), MidpointRounding.AwayFromZero)));
            return pixels;
        }
        private void UpdatePositions() {
            List<double> positions = new List<double>();
            foreach (TrafficLane tl in mainController.road.lanes)
            {
                if (tl != null)
                {
                    positions.Add(tl.position);
                    if (tl.vehicle != null)
                    {
                        if (tl.position - tl.vehicle.lastContact >= 50)
                        {
                            addToDataGridView(tl.vehicle.name, "Current location = " + (int)(tl.position));
                            tl.vehicle.lastContact = (int)tl.position;
                        }
                        if ((tl.vehicle.curSpeed <= 0.1) && (tl.vehicle.finishRegistered!=true))
                        {
                            addToDataGridView(tl.vehicle.name, "Finished at location = " + Math.Round(tl.position));
                            tl.vehicle.finishRegistered = true;
                        }                       
                    }
                }
            }
            List<int> pixels = positionToPixels(positions);
            vehiclePicture1.Left = pixels[0];
            vehiclePicture2.Left = pixels[1];
            vehiclePicture3.Left = pixels[2];
            vehiclePicture4.Left = pixels[3];
            vehiclePicture5.Left = pixels[4];
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
            addToDataGridView("Main Window", "Simulation started");
            mainController.startSimulation();
            simulationTimer.Interval = Road.UPDATE_DELAY_MSEC;
            simulationTimer.Enabled = true;
            startTime = DateTime.Now;
            toolStripButton4.Enabled = true;
            toolStripButton5.Enabled = false;
            runningFlag = true;
            sw.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void addToDataGridView(string source,string message) {
            //try
            //{
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = source;
                row.Cells[1].Value = message;
                dataGridView1.Rows.Add(row);
            /*}
            catch (Exception)
            {
                //MessageBox.Show("Please stop the simulation before changing tab", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }*/
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addToDataGridView("User","Open vehicle control dialog");
            mainController.reinitialize();
            //mainController.road = new Road();
            vehicleControlWindow.reinit();
            vehicleControlWindow.ShowDialog();
            mainController.updateFuelStatus();
            mainController.calculateMaxDistance();
            mainController.calculateAcceleration();
            if(!mainController.placeVehicles())
            {
                MessageBox.Show("Some vehicles are not placed due rules restrictions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
            showPlacement(mainController.road);
            HashSet<String> vehicleNames = new HashSet<String>();
            foreach (TrafficLane tl in mainController.road.lanes)
                if (tl.vehicle != null)
                    vehicleNames.Add(tl.vehicle.name);
            foreach (String name in vehicleNames)
                if(!comboBox1.Items.Contains(name))
                    comboBox1.Items.Add(name);
            toolStripButton5.Enabled = true;
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
            saveFileDialog1.Filter = "Excel xls file (*.xls)|*.xls|Excel xlsx file (*.xlsx)|*.xlsx";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") {
                LogProvider.logExcel(dataGridView1, saveFileDialog1.FileName);
                addToDataGridView("Log Window", "Imported to xls file");
            }
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word doc file (*.docx)|*.docx|Word docx file(*.doc)|*.doc";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                LogProvider.logWord(dataGridView1, saveFileDialog1.FileName);
                addToDataGridView("Log Window", "Imported to doc file");
            }
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
            addToDataGridView("Main Window", "Simulation stopped");
            mainController.stopSimulation();
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = true;
            sw.Stop();
        }

        private void vehicle_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vehilcePicture1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        List<DataGridViewRow> filterBackup = new List<DataGridViewRow>(); 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Filter:'"+comboBox1.SelectedItem+"'");
            if (comboBox1.SelectedItem.Equals("--Any--"))
            {
                dataGridView1.Rows.Clear();
               // dataGridView1.Refresh();
                foreach(DataGridViewRow row in filterBackup)
                    if(!dataGridView1.Rows.Contains(row))
                        dataGridView1.Rows.Add(row);
            }
            else
            {
                List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();                
                for (int i = 0; i < dataGridView1.RowCount; i++) {
                    if(!filterBackup.Contains(dataGridView1.Rows[i]) && i!=dataGridView1.RowCount-1)
                        filterBackup.Add(dataGridView1.Rows[i]);
                    if (i != dataGridView1.RowCount - 1 && !dataGridView1.Rows[i].Cells[0].Value.Equals(comboBox1.SelectedItem))
                        rowsToDelete.Add(dataGridView1.Rows[i]);
                }
                foreach (DataGridViewRow i in rowsToDelete)
                {
                    dataGridView1.Rows.Remove(i);
                }           
            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //mainController.stopSimulation();
        }
        public void vehicleStopped(String vehicle_name, double stop_location)
        {
            addToDataGridView(vehicle_name, "Finished at location = "+Math.Round(stop_location));
        }
        public void simulationFinished()
        {
            addToDataGridView("Main Window", "Simulatuion is finished");
        }
    }
}
