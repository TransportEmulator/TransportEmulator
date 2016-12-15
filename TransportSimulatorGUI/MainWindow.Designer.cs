using System.Drawing;

namespace TransportSimulatorGUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fuelStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lane_1 = new System.Windows.Forms.Panel();
            this.vehiclePicture1 = new System.Windows.Forms.PictureBox();
            this.lane_5 = new System.Windows.Forms.Panel();
            this.vehiclePicture5 = new System.Windows.Forms.PictureBox();
            this.lane_4 = new System.Windows.Forms.Panel();
            this.vehiclePicture4 = new System.Windows.Forms.PictureBox();
            this.lane_3 = new System.Windows.Forms.Panel();
            this.vehiclePicture3 = new System.Windows.Forms.PictureBox();
            this.lane_2 = new System.Windows.Forms.Panel();
            this.vehiclePicture2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.fuelContolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.lane_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture1)).BeginInit();
            this.lane_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture5)).BeginInit();
            this.lane_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture4)).BeginInit();
            this.lane_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture3)).BeginInit();
            this.lane_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.fuelStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "status_label_1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // fuelStatusLabel
            // 
            this.fuelStatusLabel.Name = "fuelStatusLabel";
            this.fuelStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.fuelStatusLabel.Text = "status_label_2";
            this.fuelStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 377);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulate";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lane_1);
            this.panel1.Controls.Add(this.lane_5);
            this.panel1.Controls.Add(this.lane_4);
            this.panel1.Controls.Add(this.lane_3);
            this.panel1.Controls.Add(this.lane_2);
            this.panel1.Location = new System.Drawing.Point(44, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 352);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lane_1
            // 
            this.lane_1.BackColor = System.Drawing.Color.Transparent;
            this.lane_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lane_1.Controls.Add(this.vehiclePicture1);
            this.lane_1.Location = new System.Drawing.Point(2, 1);
            this.lane_1.Margin = new System.Windows.Forms.Padding(1);
            this.lane_1.Name = "lane_1";
            this.lane_1.Size = new System.Drawing.Size(812, 65);
            this.lane_1.TabIndex = 4;
            // 
            // vehiclePicture1
            // 
            this.vehiclePicture1.Location = new System.Drawing.Point(3, 0);
            this.vehiclePicture1.Name = "vehiclePicture1";
            this.vehiclePicture1.Size = new System.Drawing.Size(70, 62);
            this.vehiclePicture1.TabIndex = 0;
            this.vehiclePicture1.TabStop = false;
            this.vehiclePicture1.Click += new System.EventHandler(this.vehilcePicture1_Click);
            // 
            // lane_5
            // 
            this.lane_5.BackColor = System.Drawing.Color.Transparent;
            this.lane_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lane_5.Controls.Add(this.vehiclePicture5);
            this.lane_5.Location = new System.Drawing.Point(1, 285);
            this.lane_5.Margin = new System.Windows.Forms.Padding(1);
            this.lane_5.Name = "lane_5";
            this.lane_5.Size = new System.Drawing.Size(812, 65);
            this.lane_5.TabIndex = 5;
            // 
            // vehiclePicture5
            // 
            this.vehiclePicture5.Location = new System.Drawing.Point(4, 4);
            this.vehiclePicture5.Name = "vehiclePicture5";
            this.vehiclePicture5.Size = new System.Drawing.Size(70, 59);
            this.vehiclePicture5.TabIndex = 4;
            this.vehiclePicture5.TabStop = false;
            // 
            // lane_4
            // 
            this.lane_4.BackColor = System.Drawing.Color.Transparent;
            this.lane_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lane_4.Controls.Add(this.vehiclePicture4);
            this.lane_4.Location = new System.Drawing.Point(1, 213);
            this.lane_4.Margin = new System.Windows.Forms.Padding(1);
            this.lane_4.Name = "lane_4";
            this.lane_4.Size = new System.Drawing.Size(812, 65);
            this.lane_4.TabIndex = 4;
            // 
            // vehiclePicture4
            // 
            this.vehiclePicture4.Location = new System.Drawing.Point(1, 6);
            this.vehiclePicture4.Name = "vehiclePicture4";
            this.vehiclePicture4.Size = new System.Drawing.Size(70, 59);
            this.vehiclePicture4.TabIndex = 3;
            this.vehiclePicture4.TabStop = false;
            // 
            // lane_3
            // 
            this.lane_3.BackColor = System.Drawing.Color.Transparent;
            this.lane_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lane_3.Controls.Add(this.vehiclePicture3);
            this.lane_3.Location = new System.Drawing.Point(0, 139);
            this.lane_3.Margin = new System.Windows.Forms.Padding(1);
            this.lane_3.Name = "lane_3";
            this.lane_3.Size = new System.Drawing.Size(812, 65);
            this.lane_3.TabIndex = 3;
            // 
            // vehiclePicture3
            // 
            this.vehiclePicture3.Location = new System.Drawing.Point(5, 9);
            this.vehiclePicture3.Name = "vehiclePicture3";
            this.vehiclePicture3.Size = new System.Drawing.Size(67, 56);
            this.vehiclePicture3.TabIndex = 2;
            this.vehiclePicture3.TabStop = false;
            // 
            // lane_2
            // 
            this.lane_2.BackColor = System.Drawing.Color.Transparent;
            this.lane_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lane_2.Controls.Add(this.vehiclePicture2);
            this.lane_2.Location = new System.Drawing.Point(1, 72);
            this.lane_2.Margin = new System.Windows.Forms.Padding(1);
            this.lane_2.Name = "lane_2";
            this.lane_2.Size = new System.Drawing.Size(812, 65);
            this.lane_2.TabIndex = 2;
            // 
            // vehiclePicture2
            // 
            this.vehiclePicture2.Location = new System.Drawing.Point(4, 3);
            this.vehiclePicture2.Name = "vehiclePicture2";
            this.vehiclePicture2.Size = new System.Drawing.Size(67, 60);
            this.vehiclePicture2.TabIndex = 1;
            this.vehiclePicture2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton4,
            this.fuelContolButton,
            this.toolStripButton2,
            this.toolStripButton6,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(38, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(38, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(38, 345);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Start simulation";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Stop simulation";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // fuelContolButton
            // 
            this.fuelContolButton.AccessibleDescription = "Add fuel";
            this.fuelContolButton.AccessibleName = "Add fuel";
            this.fuelContolButton.CheckOnClick = true;
            this.fuelContolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fuelContolButton.Image = ((System.Drawing.Image)(resources.GetObject("fuelContolButton.Image")));
            this.fuelContolButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fuelContolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fuelContolButton.Name = "fuelContolButton";
            this.fuelContolButton.Size = new System.Drawing.Size(36, 36);
            this.fuelContolButton.Text = "fuelControlButton";
            this.fuelContolButton.ToolTipText = "Open Fuel Control Window";
            this.fuelContolButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Vehicles on tracks";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton6.Text = "toolStripButton1";
            this.toolStripButton6.ToolTipText = "Contact developers";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logger";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(850, 345);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton7,
            this.toolStripButton10,
            this.toolStripButton11});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(38, 345);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::TransportSimulatorGUI.Properties.Resources.export_excel2;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Linen;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Import to Excel";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::TransportSimulatorGUI.Properties.Resources.export_doc;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton7.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton7.Text = "Import to Doc";
            this.toolStripButton7.ToolTipText = "Import to Doc";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton10.Text = "toolStripButton1";
            this.toolStripButton10.ToolTipText = "Contact developers";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton11.Text = "toolStripButton1";
            this.toolStripButton11.ToolTipText = "Exit";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "--Any--"});
            this.comboBox1.Location = new System.Drawing.Point(104, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Object,
            this.Event});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(814, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // Object
            // 
            this.Object.HeaderText = "Object";
            this.Object.Name = "Object";
            this.Object.ReadOnly = true;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minsk, 2016";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.lane_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture1)).EndInit();
            this.lane_5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture5)).EndInit();
            this.lane_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture4)).EndInit();
            this.lane_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture3)).EndInit();
            this.lane_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel fuelStatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton fuelContolButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lane_1;
        private System.Windows.Forms.Panel lane_2;
        private System.Windows.Forms.Panel lane_3;
        private System.Windows.Forms.Panel lane_4;
        private System.Windows.Forms.Panel lane_5;
        
        private System.Windows.Forms.PictureBox vehiclePicture1;
        Image[] images = new Image[10];
        private System.Windows.Forms.PictureBox vehiclePicture5;
        private System.Windows.Forms.PictureBox vehiclePicture4;
        private System.Windows.Forms.PictureBox vehiclePicture3;
        private System.Windows.Forms.PictureBox vehiclePicture2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

