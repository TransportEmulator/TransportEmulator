namespace TransportSimulatorGUI
{
    partial class FuelControlWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelControlWindow));
            this.dieselTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dieselAmountLabel = new System.Windows.Forms.Label();
            this.ron92AmountLabel = new System.Windows.Forms.Label();
            this.ron92Label = new System.Windows.Forms.Label();
            this.ron92TrackBar = new System.Windows.Forms.TrackBar();
            this.ron95AmountLabel = new System.Windows.Forms.Label();
            this.ron95Label = new System.Windows.Forms.Label();
            this.ron95TrackBar = new System.Windows.Forms.TrackBar();
            this.ron98AmountLabel = new System.Windows.Forms.Label();
            this.ron98Label = new System.Windows.Forms.Label();
            this.ron98TrackBar = new System.Windows.Forms.TrackBar();
            this.gasAmountLabel = new System.Windows.Forms.Label();
            this.gasLabel = new System.Windows.Forms.Label();
            this.gasTrackBar = new System.Windows.Forms.TrackBar();
            this.updateFuelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dieselTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ron92TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ron95TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ron98TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dieselTrackBar
            // 
            this.dieselTrackBar.AccessibleDescription = "dieselTrackBar";
            this.dieselTrackBar.AccessibleName = "dieselTrackBar";
            this.dieselTrackBar.Location = new System.Drawing.Point(22, 36);
            this.dieselTrackBar.Maximum = 100;
            this.dieselTrackBar.Name = "dieselTrackBar";
            this.dieselTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.dieselTrackBar.Size = new System.Drawing.Size(45, 184);
            this.dieselTrackBar.SmallChange = 5;
            this.dieselTrackBar.TabIndex = 0;
            this.dieselTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.dieselTrackBar.Scroll += new System.EventHandler(this.dieselTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "dieselLabel";
            this.label1.AccessibleName = "dieselLabel";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diesel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dieselAmountLabel
            // 
            this.dieselAmountLabel.AccessibleDescription = "dieselAmount";
            this.dieselAmountLabel.AccessibleName = "dieselAmount";
            this.dieselAmountLabel.AutoSize = true;
            this.dieselAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dieselAmountLabel.Location = new System.Drawing.Point(21, 220);
            this.dieselAmountLabel.Name = "dieselAmountLabel";
            this.dieselAmountLabel.Size = new System.Drawing.Size(20, 24);
            this.dieselAmountLabel.TabIndex = 2;
            this.dieselAmountLabel.Text = "0";
            this.dieselAmountLabel.Click += new System.EventHandler(this.dieselAmountLabel_Click);
            // 
            // ron92AmountLabel
            // 
            this.ron92AmountLabel.AccessibleDescription = "ron92Amount";
            this.ron92AmountLabel.AccessibleName = "ron92Amount";
            this.ron92AmountLabel.AutoSize = true;
            this.ron92AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ron92AmountLabel.Location = new System.Drawing.Point(92, 219);
            this.ron92AmountLabel.Name = "ron92AmountLabel";
            this.ron92AmountLabel.Size = new System.Drawing.Size(20, 24);
            this.ron92AmountLabel.TabIndex = 5;
            this.ron92AmountLabel.Text = "0";
            // 
            // ron92Label
            // 
            this.ron92Label.AccessibleDescription = "ron92Label";
            this.ron92Label.AccessibleName = "ron92Label";
            this.ron92Label.AutoSize = true;
            this.ron92Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ron92Label.Location = new System.Drawing.Point(73, 9);
            this.ron92Label.Name = "ron92Label";
            this.ron92Label.Size = new System.Drawing.Size(72, 24);
            this.ron92Label.TabIndex = 4;
            this.ron92Label.Text = "RON92";
            this.ron92Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // ron92TrackBar
            // 
            this.ron92TrackBar.AccessibleDescription = "ron92TrackBar";
            this.ron92TrackBar.AccessibleName = "ron92TrackBar";
            this.ron92TrackBar.Location = new System.Drawing.Point(93, 36);
            this.ron92TrackBar.Maximum = 100;
            this.ron92TrackBar.Name = "ron92TrackBar";
            this.ron92TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ron92TrackBar.Size = new System.Drawing.Size(45, 184);
            this.ron92TrackBar.SmallChange = 5;
            this.ron92TrackBar.TabIndex = 3;
            this.ron92TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ron92TrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ron95AmountLabel
            // 
            this.ron95AmountLabel.AccessibleDescription = "ron95Amount";
            this.ron95AmountLabel.AccessibleName = "ron95Amount";
            this.ron95AmountLabel.AutoSize = true;
            this.ron95AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ron95AmountLabel.Location = new System.Drawing.Point(171, 220);
            this.ron95AmountLabel.Name = "ron95AmountLabel";
            this.ron95AmountLabel.Size = new System.Drawing.Size(20, 24);
            this.ron95AmountLabel.TabIndex = 8;
            this.ron95AmountLabel.Text = "0";
            // 
            // ron95Label
            // 
            this.ron95Label.AccessibleDescription = "ron95Label";
            this.ron95Label.AccessibleName = "ron95Label";
            this.ron95Label.AutoSize = true;
            this.ron95Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ron95Label.Location = new System.Drawing.Point(152, 9);
            this.ron95Label.Name = "ron95Label";
            this.ron95Label.Size = new System.Drawing.Size(72, 24);
            this.ron95Label.TabIndex = 7;
            this.ron95Label.Text = "RON95";
            // 
            // ron95TrackBar
            // 
            this.ron95TrackBar.AccessibleDescription = "ron95TrackBar";
            this.ron95TrackBar.AccessibleName = "ron95TrackBar";
            this.ron95TrackBar.Location = new System.Drawing.Point(171, 36);
            this.ron95TrackBar.Maximum = 100;
            this.ron95TrackBar.Name = "ron95TrackBar";
            this.ron95TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ron95TrackBar.Size = new System.Drawing.Size(45, 184);
            this.ron95TrackBar.SmallChange = 5;
            this.ron95TrackBar.TabIndex = 6;
            this.ron95TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ron95TrackBar.Scroll += new System.EventHandler(this.ron95TrackBar_Scroll);
            // 
            // ron98AmountLabel
            // 
            this.ron98AmountLabel.AccessibleDescription = "ron98Amount";
            this.ron98AmountLabel.AccessibleName = "ron98Amount";
            this.ron98AmountLabel.AutoSize = true;
            this.ron98AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ron98AmountLabel.Location = new System.Drawing.Point(242, 220);
            this.ron98AmountLabel.Name = "ron98AmountLabel";
            this.ron98AmountLabel.Size = new System.Drawing.Size(20, 24);
            this.ron98AmountLabel.TabIndex = 11;
            this.ron98AmountLabel.Text = "0";
            // 
            // ron98Label
            // 
            this.ron98Label.AccessibleDescription = "ron98Label";
            this.ron98Label.AccessibleName = "ron98Label";
            this.ron98Label.AutoSize = true;
            this.ron98Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ron98Label.Location = new System.Drawing.Point(223, 9);
            this.ron98Label.Name = "ron98Label";
            this.ron98Label.Size = new System.Drawing.Size(72, 24);
            this.ron98Label.TabIndex = 10;
            this.ron98Label.Text = "RON98";
            // 
            // ron98TrackBar
            // 
            this.ron98TrackBar.AccessibleDescription = "ron98TrackBar";
            this.ron98TrackBar.AccessibleName = "ron98TrackBar";
            this.ron98TrackBar.Location = new System.Drawing.Point(242, 36);
            this.ron98TrackBar.Maximum = 100;
            this.ron98TrackBar.Name = "ron98TrackBar";
            this.ron98TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ron98TrackBar.Size = new System.Drawing.Size(45, 184);
            this.ron98TrackBar.SmallChange = 5;
            this.ron98TrackBar.TabIndex = 9;
            this.ron98TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ron98TrackBar.Scroll += new System.EventHandler(this.ron98TrackBar_Scroll);
            // 
            // gasAmountLabel
            // 
            this.gasAmountLabel.AccessibleDescription = "gasAmount";
            this.gasAmountLabel.AccessibleName = "gasAmount";
            this.gasAmountLabel.AutoSize = true;
            this.gasAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gasAmountLabel.Location = new System.Drawing.Point(309, 219);
            this.gasAmountLabel.Name = "gasAmountLabel";
            this.gasAmountLabel.Size = new System.Drawing.Size(20, 24);
            this.gasAmountLabel.TabIndex = 14;
            this.gasAmountLabel.Text = "0";
            // 
            // gasLabel
            // 
            this.gasLabel.AccessibleDescription = "gasLabel";
            this.gasLabel.AccessibleName = "gasLabel";
            this.gasLabel.AutoSize = true;
            this.gasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gasLabel.Location = new System.Drawing.Point(302, 9);
            this.gasLabel.Name = "gasLabel";
            this.gasLabel.Size = new System.Drawing.Size(43, 24);
            this.gasLabel.TabIndex = 13;
            this.gasLabel.Text = "Gas";
            // 
            // gasTrackBar
            // 
            this.gasTrackBar.AccessibleDescription = "gasTrackBar";
            this.gasTrackBar.AccessibleName = "gasTrackBar";
            this.gasTrackBar.Location = new System.Drawing.Point(309, 36);
            this.gasTrackBar.Maximum = 100;
            this.gasTrackBar.Name = "gasTrackBar";
            this.gasTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gasTrackBar.Size = new System.Drawing.Size(45, 184);
            this.gasTrackBar.SmallChange = 5;
            this.gasTrackBar.TabIndex = 12;
            this.gasTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gasTrackBar.Scroll += new System.EventHandler(this.gasTrackBar_Scroll);
            // 
            // updateFuelButton
            // 
            this.updateFuelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFuelButton.Location = new System.Drawing.Point(96, 247);
            this.updateFuelButton.Name = "updateFuelButton";
            this.updateFuelButton.Size = new System.Drawing.Size(166, 33);
            this.updateFuelButton.TabIndex = 15;
            this.updateFuelButton.Text = "Update fuel";
            this.updateFuelButton.UseVisualStyleBackColor = true;
            this.updateFuelButton.Click += new System.EventHandler(this.updateFuelButton_Click);
            // 
            // FuelControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 291);
            this.Controls.Add(this.updateFuelButton);
            this.Controls.Add(this.gasAmountLabel);
            this.Controls.Add(this.gasLabel);
            this.Controls.Add(this.gasTrackBar);
            this.Controls.Add(this.ron98AmountLabel);
            this.Controls.Add(this.ron98Label);
            this.Controls.Add(this.ron98TrackBar);
            this.Controls.Add(this.ron95AmountLabel);
            this.Controls.Add(this.ron95Label);
            this.Controls.Add(this.ron95TrackBar);
            this.Controls.Add(this.ron92AmountLabel);
            this.Controls.Add(this.ron92Label);
            this.Controls.Add(this.ron92TrackBar);
            this.Controls.Add(this.dieselAmountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dieselTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuelControlWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuelControlWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dieselTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ron92TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ron95TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ron98TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar dieselTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dieselAmountLabel;
        private System.Windows.Forms.Label ron92AmountLabel;
        private System.Windows.Forms.Label ron92Label;
        private System.Windows.Forms.TrackBar ron92TrackBar;
        private System.Windows.Forms.Label ron95AmountLabel;
        private System.Windows.Forms.Label ron95Label;
        private System.Windows.Forms.TrackBar ron95TrackBar;
        private System.Windows.Forms.Label ron98AmountLabel;
        private System.Windows.Forms.Label ron98Label;
        private System.Windows.Forms.TrackBar ron98TrackBar;
        private System.Windows.Forms.Label gasAmountLabel;
        private System.Windows.Forms.Label gasLabel;
        private System.Windows.Forms.TrackBar gasTrackBar;
        private System.Windows.Forms.Button updateFuelButton;
    }
}