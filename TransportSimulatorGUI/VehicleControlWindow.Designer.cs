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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.trolleybusTab = new System.Windows.Forms.TabPage();
            this.carTab = new System.Windows.Forms.TabPage();
            this.tabImages = new System.Windows.Forms.ImageList(this.components);
            this.loaderTab = new System.Windows.Forms.TabPage();
            this.busTab = new System.Windows.Forms.TabPage();
            this.bikeTab = new System.Windows.Forms.TabPage();
            this.scooterTab = new System.Windows.Forms.TabPage();
            this.motorcycleTab = new System.Windows.Forms.TabPage();
            this.tankTab = new System.Windows.Forms.TabPage();
            this.tramTab = new System.Windows.Forms.TabPage();
            this.wagonTab = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tankTab.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(378, 283);
            this.splitContainer1.SplitterDistance = 93;
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
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(93, 283);
            this.splitContainer2.SplitterDistance = 252;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(93, 252);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.tabImages;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 283);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // trolleybusTab
            // 
            this.trolleybusTab.ImageIndex = 0;
            this.trolleybusTab.Location = new System.Drawing.Point(4, 64);
            this.trolleybusTab.Name = "trolleybusTab";
            this.trolleybusTab.Padding = new System.Windows.Forms.Padding(3);
            this.trolleybusTab.Size = new System.Drawing.Size(243, 213);
            this.trolleybusTab.TabIndex = 0;
            this.trolleybusTab.UseVisualStyleBackColor = true;
            // 
            // carTab
            // 
            this.carTab.ImageIndex = 1;
            this.carTab.Location = new System.Drawing.Point(4, 64);
            this.carTab.Name = "carTab";
            this.carTab.Padding = new System.Windows.Forms.Padding(3);
            this.carTab.Size = new System.Drawing.Size(243, 213);
            this.carTab.TabIndex = 1;
            this.carTab.UseVisualStyleBackColor = true;
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
            // loaderTab
            // 
            this.loaderTab.ImageIndex = 2;
            this.loaderTab.Location = new System.Drawing.Point(4, 64);
            this.loaderTab.Name = "loaderTab";
            this.loaderTab.Size = new System.Drawing.Size(243, 213);
            this.loaderTab.TabIndex = 2;
            this.loaderTab.UseVisualStyleBackColor = true;
            // 
            // busTab
            // 
            this.busTab.ImageIndex = 3;
            this.busTab.Location = new System.Drawing.Point(4, 34);
            this.busTab.Name = "busTab";
            this.busTab.Size = new System.Drawing.Size(243, 243);
            this.busTab.TabIndex = 3;
            this.busTab.UseVisualStyleBackColor = true;
            // 
            // bikeTab
            // 
            this.bikeTab.ImageIndex = 4;
            this.bikeTab.Location = new System.Drawing.Point(4, 64);
            this.bikeTab.Name = "bikeTab";
            this.bikeTab.Size = new System.Drawing.Size(243, 213);
            this.bikeTab.TabIndex = 4;
            this.bikeTab.UseVisualStyleBackColor = true;
            // 
            // scooterTab
            // 
            this.scooterTab.ImageIndex = 5;
            this.scooterTab.Location = new System.Drawing.Point(4, 64);
            this.scooterTab.Name = "scooterTab";
            this.scooterTab.Size = new System.Drawing.Size(243, 213);
            this.scooterTab.TabIndex = 5;
            this.scooterTab.UseVisualStyleBackColor = true;
            // 
            // motorcycleTab
            // 
            this.motorcycleTab.ImageIndex = 6;
            this.motorcycleTab.Location = new System.Drawing.Point(4, 64);
            this.motorcycleTab.Name = "motorcycleTab";
            this.motorcycleTab.Size = new System.Drawing.Size(243, 213);
            this.motorcycleTab.TabIndex = 6;
            this.motorcycleTab.UseVisualStyleBackColor = true;
            // 
            // tankTab
            // 
            this.tankTab.Controls.Add(this.comboBox1);
            this.tankTab.ImageIndex = 7;
            this.tankTab.Location = new System.Drawing.Point(4, 64);
            this.tankTab.Name = "tankTab";
            this.tankTab.Size = new System.Drawing.Size(273, 215);
            this.tankTab.TabIndex = 7;
            this.tankTab.UseVisualStyleBackColor = true;
            // 
            // tramTab
            // 
            this.tramTab.ImageIndex = 8;
            this.tramTab.Location = new System.Drawing.Point(4, 64);
            this.tramTab.Name = "tramTab";
            this.tramTab.Size = new System.Drawing.Size(243, 213);
            this.tramTab.TabIndex = 8;
            this.tramTab.UseVisualStyleBackColor = true;
            // 
            // wagonTab
            // 
            this.wagonTab.ImageIndex = 9;
            this.wagonTab.Location = new System.Drawing.Point(4, 64);
            this.wagonTab.Name = "wagonTab";
            this.wagonTab.Size = new System.Drawing.Size(243, 213);
            this.wagonTab.TabIndex = 9;
            this.wagonTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bus",
            "Trolleybus",
            "Tram"});
            this.comboBox1.Location = new System.Drawing.Point(69, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // VehicleControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 283);
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
            this.tankTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage trolleybusTab;
        private System.Windows.Forms.TabPage carTab;
        private System.Windows.Forms.TabPage loaderTab;
        private System.Windows.Forms.TabPage busTab;
        private System.Windows.Forms.TabPage bikeTab;
        private System.Windows.Forms.TabPage scooterTab;
        private System.Windows.Forms.TabPage motorcycleTab;
        private System.Windows.Forms.TabPage tankTab;
        private System.Windows.Forms.TabPage tramTab;
        private System.Windows.Forms.TabPage wagonTab;
        private System.Windows.Forms.ImageList tabImages;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}