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
    public partial class VehicleControlWindow : Form,IVehicleControlView
    {
        VehicleController vehicleController;
        public VehicleControlWindow()
        {
            InitializeComponent();

        }
        public ListView vehicleList {
            get { return vehicleListView; }
            set { vehicleListView = value; }
        }
         
        public int consumption
        {
            get { return (int)consumptionUpDown.Value; }
        }
        public int fuelQuantity {
            get { return (int)fuelUpDown.Value; }
        }
        public FuelType fuelType {
            get {
                switch (fuelTypeCombo.Text) {
                    case "DIESEL": return FuelType.DIESEL;
                    case "RON92": return FuelType.OCTANE_92;
                    case "RON95": return FuelType.OCTANE_95;
                    case "RON98": return FuelType.OCTANE_98;
                    case "GAS": return FuelType.GAS;
                    default: return FuelType.DIESEL;
                }
            }
        } 
        public string chosenVehicle {
            get { return tabControl1.SelectedTab.Name; }
        }

        public int maxSpeed
        {
            get{ return (int)maxSpeedUpDown.Value; }
        }

        public int driverAge
        {
            get{ return (int)ageUpDown.Value; }
        }

        public int weight
        {
            get { return (int)weightUpDown.Value; }
        }

        public string name
        {
            get { return nameTextField.Text; }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void motorizedTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == trumTab || tabControl1.SelectedTab == scooterTab || tabControl1.SelectedTab == horseDrawnCarriageTab || tabControl1.SelectedTab == trolleybusTab)
                enableFuelChose(false);
            else enableFuelChose(true);
        }
        private void enableFuelChose(Boolean b) {
            label4.Visible = b;
            label9.Visible = b;
            label10.Visible = b;
            fuelUpDown.Visible = b;
            fuelTypeCombo.Visible = b;
            consumptionUpDown.Visible = b;
        }
        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VehicleControlWindow_Load(object sender, EventArgs e)
        {

        }


        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setController(VehicleController vehicleController)
        {
            this.vehicleController = vehicleController;
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            Vehicle newVehicle = null;
            newVehicle = this.vehicleController.addVehicle();
            if (newVehicle==null)
                MessageBox.Show("No enough fuel quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                int imgNum;
                switch (newVehicle.GetType().Name) {
                    case "Trolleybus":imgNum =0;break;
                    case "Car": imgNum =1; break;
                    case "Truck": imgNum =2; break;
                    case "Bus": imgNum =3; break;
                    case "Bicycle": imgNum =4; break;
                    case "Scooter": imgNum =5; break;
                    case "Bike": imgNum =6; break;
                    case "Tank": imgNum =7; break;
                    case "Trum:": imgNum =8; break;
                    case "HorseDrawnCarriage": imgNum =9; break;
                    default: imgNum =1;break;

                }
                vehicleListView.Items.Add(newVehicle.name,imgNum);
            }
            Console.WriteLine("SELECTED:"+tabControl1.SelectedTab.Name+","+
                name+","+driverAge+","+weight+","+maxSpeed);
            //  vehicleController
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
