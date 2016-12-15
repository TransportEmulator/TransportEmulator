using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TransportSimulatorController;
namespace TransportSimulatorGUI
{
    public partial class VehicleControlWindow : Form,IVehicleControlView
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        VehicleController vehicleController;
        public VehicleControlWindow()
        {
            InitializeComponent();
            ageUpDown.Value = 18;
            fuelTypeCombo.SelectedIndex = 0;
            vehicleListView.Items.Add("", 10);
            vehicleListView.Items.Add("", 10);
            vehicleListView.Items.Add("", 10);
            vehicleListView.Items.Add("", 10);
            vehicleListView.Items.Add("", 10);
            vehicleListView.Width = 40;
            ListViewItem_SetSpacing(vehicleListView, 40,32);

        }
        public int MakeLong(short lowPart, short highPart)
        {
            return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        }

        public void ListViewItem_SetSpacing(ListView listview, short leftPadding, short topPadding)
        {
            const int LVM_FIRST = 0x1000;
            const int LVM_SETICONSPACING = LVM_FIRST + 53;
            SendMessage(listview.Handle, LVM_SETICONSPACING, IntPtr.Zero, (IntPtr)MakeLong(leftPadding, topPadding));
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
        public int startSpeed
        {
            get { return (int)startSpeedUpDown.Value; }
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
            foreach (ListViewItem item in vehicleListView.Items) {
                if (item.ImageIndex == 11)
                    item.ImageIndex = 10;
                if(item.Selected && item.ImageIndex ==10)
                    item.ImageIndex = 11;
            }
           // if (vehicleListView.SelectedItems[0].ImageIndex==10)
           //     vehicleListView.SelectedItems[0].ImageIndex = 11;
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
            try
            {
                ListViewItem lv = vehicleListView.SelectedItems[0];
                newVehicle = this.vehicleController.addVehicle();
                if (newVehicle == null)
                    MessageBox.Show("No enough fuel quantity or fuel consumption is zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int imgNum;
                    imgNum = newVehicle.ID;
                    lv.ImageIndex = imgNum;
                    lv.Name = newVehicle.name.Equals("") ? newVehicle.GetType().Name : newVehicle.name;
                    //vehicleListView.Items.Add(newVehicle.name,imgNum);
                }
                Console.WriteLine("SELECTED:" + tabControl1.SelectedTab.Name + "," +
                    name + "," + driverAge + "," + weight + "," + maxSpeed);
                //  vehicleController
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try to choose slot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();           
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            vehicleController.deleteVehicle(vehicleListView.SelectedItems[0].Text);
            vehicleListView.SelectedItems[0].ImageIndex = 11;
        }

        private void consumptionUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
