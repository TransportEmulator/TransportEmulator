﻿using System;
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
        private InformationWindow informationWindow = new InformationWindow();
        private VehicleControlWindow vehicleControlWindow = new VehicleControlWindow();
        public MainWindow()
        {
            InitializeComponent();
            AddOwnedForm(fuelControlWindow);
            AddOwnedForm(informationWindow);
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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            vehicleControlWindow.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            informationWindow.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}