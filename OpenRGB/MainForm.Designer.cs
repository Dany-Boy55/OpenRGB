namespace OpenRGB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_tabControl = new System.Windows.Forms.TabControl();
            this.Start_tabPage = new System.Windows.Forms.TabPage();
            this.Devices_tabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Settings_tabPage = new System.Windows.Forms.TabPage();
            this.Help_tabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deviceBox1 = new OpenRGB.deviceBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Main_tabControl.SuspendLayout();
            this.Devices_tabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Settings_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tabControl
            // 
            this.Main_tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Main_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_tabControl.Controls.Add(this.Start_tabPage);
            this.Main_tabControl.Controls.Add(this.Devices_tabPage);
            this.Main_tabControl.Controls.Add(this.Settings_tabPage);
            this.Main_tabControl.Controls.Add(this.Help_tabPage);
            this.Main_tabControl.HotTrack = true;
            this.Main_tabControl.Location = new System.Drawing.Point(8, 8);
            this.Main_tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.Main_tabControl.Multiline = true;
            this.Main_tabControl.Name = "Main_tabControl";
            this.Main_tabControl.SelectedIndex = 0;
            this.Main_tabControl.Size = new System.Drawing.Size(701, 382);
            this.Main_tabControl.TabIndex = 1;
            // 
            // Start_tabPage
            // 
            this.Start_tabPage.Location = new System.Drawing.Point(23, 4);
            this.Start_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Start_tabPage.Name = "Start_tabPage";
            this.Start_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.Start_tabPage.Size = new System.Drawing.Size(674, 374);
            this.Start_tabPage.TabIndex = 0;
            this.Start_tabPage.Text = "Start";
            this.Start_tabPage.UseVisualStyleBackColor = true;
            // 
            // Devices_tabPage
            // 
            this.Devices_tabPage.Controls.Add(this.panel1);
            this.Devices_tabPage.Controls.Add(this.flowLayoutPanel1);
            this.Devices_tabPage.Location = new System.Drawing.Point(23, 4);
            this.Devices_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Devices_tabPage.Name = "Devices_tabPage";
            this.Devices_tabPage.Size = new System.Drawing.Size(674, 374);
            this.Devices_tabPage.TabIndex = 1;
            this.Devices_tabPage.Text = "Devices";
            this.Devices_tabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(173, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 368);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.deviceBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 367);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Settings_tabPage
            // 
            this.Settings_tabPage.Controls.Add(this.tableLayoutPanel1);
            this.Settings_tabPage.Location = new System.Drawing.Point(23, 4);
            this.Settings_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Settings_tabPage.Name = "Settings_tabPage";
            this.Settings_tabPage.Size = new System.Drawing.Size(674, 374);
            this.Settings_tabPage.TabIndex = 2;
            this.Settings_tabPage.Text = "Settings";
            this.Settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // Help_tabPage
            // 
            this.Help_tabPage.Location = new System.Drawing.Point(23, 4);
            this.Help_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Help_tabPage.Name = "Help_tabPage";
            this.Help_tabPage.Size = new System.Drawing.Size(674, 374);
            this.Help_tabPage.TabIndex = 3;
            this.Help_tabPage.Text = "Help";
            this.Help_tabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a device to beign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deviceBox1
            // 
            this.deviceBox1.BackColor = System.Drawing.SystemColors.Control;
            this.deviceBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceBox1.BackgroundImage")));
            this.deviceBox1.Location = new System.Drawing.Point(5, 6);
            this.deviceBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deviceBox1.Name = "deviceBox1";
            this.deviceBox1.PortName = null;
            this.deviceBox1.Size = new System.Drawing.Size(150, 150);
            this.deviceBox1.TabIndex = 0;
            this.deviceBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deviceBox1_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OpenRGB Serial Device",
            "Logitech Peripheral"});
            this.comboBox1.Location = new System.Drawing.Point(105, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 398);
            this.Controls.Add(this.Main_tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Open RGB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Main_tabControl.ResumeLayout(false);
            this.Devices_tabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Settings_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Main_tabControl;
        private System.Windows.Forms.TabPage Start_tabPage;
        private System.Windows.Forms.TabPage Devices_tabPage;
        private System.Windows.Forms.TabPage Settings_tabPage;
        private System.Windows.Forms.TabPage Help_tabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private deviceBox deviceBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

