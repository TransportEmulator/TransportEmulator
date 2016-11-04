namespace TransportSimulatorGUI
{
    partial class VehicleControlWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleControlWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.trolleybusTab = new System.Windows.Forms.TabPage();
            this.carTab = new System.Windows.Forms.TabPage();
            this.loaderTab = new System.Windows.Forms.TabPage();
            this.busTab = new System.Windows.Forms.TabPage();
            this.bikeTab = new System.Windows.Forms.TabPage();
            this.scooterTab = new System.Windows.Forms.TabPage();
            this.motorcycleTab = new System.Windows.Forms.TabPage();
            this.tramTab = new System.Windows.Forms.TabPage();
            this.wagonTab = new System.Windows.Forms.TabPage();
            this.tabImages = new System.Windows.Forms.ImageList(this.components);
            this.tankTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.addButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(458, 308);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer2.Size = new System.Drawing.Size(172, 308);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(172, 250);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 54);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.trolleybusTab);
            this.tabControl1.Controls.Add(this.carTab);
            this.tabControl1.Controls.Add(this.loaderTab);
            this.tabControl1.Controls.Add(this.busTab);
            this.tabControl1.Controls.Add(this.bikeTab);
            this.tabControl1.Controls.Add(this.scooterTab);
            this.tabControl1.Controls.Add(this.motorcycleTab);
            this.tabControl1.Controls.Add(this.tankTab);
            this.tabControl1.Controls.Add(this.tramTab);
            this.tabControl1.Controls.Add(this.wagonTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ImageList = this.tabImages;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 149);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // trolleybusTab
            // 
            this.trolleybusTab.ImageIndex = 0;
            this.trolleybusTab.Location = new System.Drawing.Point(4, 100);
            this.trolleybusTab.Name = "trolleybusTab";
            this.trolleybusTab.Padding = new System.Windows.Forms.Padding(3);
            this.trolleybusTab.Size = new System.Drawing.Size(213, 45);
            this.trolleybusTab.TabIndex = 0;
            this.trolleybusTab.UseVisualStyleBackColor = true;
            // 
            // carTab
            // 
            this.carTab.ImageIndex = 1;
            this.carTab.Location = new System.Drawing.Point(4, 67);
            this.carTab.Name = "carTab";
            this.carTab.Padding = new System.Windows.Forms.Padding(3);
            this.carTab.Size = new System.Drawing.Size(254, 121);
            this.carTab.TabIndex = 1;
            this.carTab.UseVisualStyleBackColor = true;
            // 
            // loaderTab
            // 
            this.loaderTab.ImageIndex = 2;
            this.loaderTab.Location = new System.Drawing.Point(4, 67);
            this.loaderTab.Name = "loaderTab";
            this.loaderTab.Size = new System.Drawing.Size(254, 121);
            this.loaderTab.TabIndex = 2;
            this.loaderTab.UseVisualStyleBackColor = true;
            // 
            // busTab
            // 
            this.busTab.ImageIndex = 3;
            this.busTab.Location = new System.Drawing.Point(4, 67);
            this.busTab.Name = "busTab";
            this.busTab.Size = new System.Drawing.Size(254, 121);
            this.busTab.TabIndex = 3;
            this.busTab.UseVisualStyleBackColor = true;
            // 
            // bikeTab
            // 
            this.bikeTab.ImageIndex = 4;
            this.bikeTab.Location = new System.Drawing.Point(4, 67);
            this.bikeTab.Name = "bikeTab";
            this.bikeTab.Size = new System.Drawing.Size(254, 121);
            this.bikeTab.TabIndex = 4;
            this.bikeTab.UseVisualStyleBackColor = true;
            // 
            // scooterTab
            // 
            this.scooterTab.ImageIndex = 5;
            this.scooterTab.Location = new System.Drawing.Point(4, 67);
            this.scooterTab.Name = "scooterTab";
            this.scooterTab.Size = new System.Drawing.Size(254, 121);
            this.scooterTab.TabIndex = 5;
            this.scooterTab.UseVisualStyleBackColor = true;
            // 
            // motorcycleTab
            // 
            this.motorcycleTab.ImageIndex = 6;
            this.motorcycleTab.Location = new System.Drawing.Point(4, 67);
            this.motorcycleTab.Name = "motorcycleTab";
            this.motorcycleTab.Size = new System.Drawing.Size(274, 78);
            this.motorcycleTab.TabIndex = 6;
            this.motorcycleTab.UseVisualStyleBackColor = true;
            // 
            // tramTab
            // 
            this.tramTab.ImageIndex = 8;
            this.tramTab.Location = new System.Drawing.Point(4, 67);
            this.tramTab.Name = "tramTab";
            this.tramTab.Size = new System.Drawing.Size(254, 121);
            this.tramTab.TabIndex = 8;
            this.tramTab.UseVisualStyleBackColor = true;
            // 
            // wagonTab
            // 
            this.wagonTab.ImageIndex = 9;
            this.wagonTab.Location = new System.Drawing.Point(4, 67);
            this.wagonTab.Name = "wagonTab";
            this.wagonTab.Size = new System.Drawing.Size(254, 121);
            this.wagonTab.TabIndex = 9;
            this.wagonTab.UseVisualStyleBackColor = true;
            // 
            // tabImages
            // 
            this.tabImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabImages.ImageStream")));
            this.tabImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tabImages.Images.SetKeyName(0, "trolleybus.png");
            this.tabImages.Images.SetKeyName(1, "car.png");
            this.tabImages.Images.SetKeyName(2, "loader (1).png");
            this.tabImages.Images.SetKeyName(3, "bus.png");
            this.tabImages.Images.SetKeyName(4, "bicycle.png");
            this.tabImages.Images.SetKeyName(5, "kick-scooter.png");
            this.tabImages.Images.SetKeyName(6, "motorcycle.png");
            this.tabImages.Images.SetKeyName(7, "tank.png");
            this.tabImages.Images.SetKeyName(8, "tram.png");
            this.tabImages.Images.SetKeyName(9, "wagon.png");
            // 
            // tankTab
            // 
            this.tankTab.ImageIndex = 7;
            this.tankTab.Location = new System.Drawing.Point(4, 67);
            this.tankTab.Name = "tankTab";
            this.tankTab.Size = new System.Drawing.Size(274, 78);
            this.tankTab.TabIndex = 7;
            this.tankTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 159);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.addButton);
            this.splitContainer3.Panel2.Controls.Add(this.resetButton);
            this.splitContainer3.Size = new System.Drawing.Size(282, 159);
            this.splitContainer3.SplitterDistance = 102;
            this.splitContainer3.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 53);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resetButton.Location = new System.Drawing.Point(161, 0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 53);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35461F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.55445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.44555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(143, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 308);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VehicleControlWindow";
            this.Text = "VehicleControlWindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage trolleybusTab;
        private System.Windows.Forms.TabPage carTab;
        private System.Windows.Forms.TabPage loaderTab;
        private System.Windows.Forms.TabPage busTab;
        private System.Windows.Forms.TabPage bikeTab;
        private System.Windows.Forms.TabPage scooterTab;
        private System.Windows.Forms.TabPage motorcycleTab;
        private System.Windows.Forms.TabPage tramTab;
        private System.Windows.Forms.TabPage wagonTab;
        private System.Windows.Forms.ImageList tabImages;
        private System.Windows.Forms.TabPage tankTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}