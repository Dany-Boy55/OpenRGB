﻿namespace OpenRGB
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Devices_tabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Settings_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Help_tabPage = new System.Windows.Forms.TabPage();
            this.Add_deviceBox = new OpenRGB.deviceBox();
            this.Main_tabControl.SuspendLayout();
            this.Start_tabPage.SuspendLayout();
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
            this.Main_tabControl.Location = new System.Drawing.Point(11, 10);
            this.Main_tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Main_tabControl.Multiline = true;
            this.Main_tabControl.Name = "Main_tabControl";
            this.Main_tabControl.SelectedIndex = 0;
            this.Main_tabControl.Size = new System.Drawing.Size(935, 470);
            this.Main_tabControl.TabIndex = 1;
            // 
            // Start_tabPage
            // 
            this.Start_tabPage.Controls.Add(this.flowLayoutPanel2);
            this.Start_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Start_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_tabPage.Name = "Start_tabPage";
            this.Start_tabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Start_tabPage.TabIndex = 0;
            this.Start_tabPage.Text = "Start";
            this.Start_tabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(894, 452);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // Devices_tabPage
            // 
            this.Devices_tabPage.Controls.Add(this.panel1);
            this.Devices_tabPage.Controls.Add(this.flowLayoutPanel1);
            this.Devices_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Devices_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Devices_tabPage.Name = "Devices_tabPage";
            this.Devices_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Devices_tabPage.TabIndex = 1;
            this.Devices_tabPage.Text = "Devices";
            this.Devices_tabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(231, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 453);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a device to beign";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Add_deviceBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 452);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Settings_tabPage
            // 
            this.Settings_tabPage.Controls.Add(this.tableLayoutPanel1);
            this.Settings_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Settings_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings_tabPage.Name = "Settings_tabPage";
            this.Settings_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Settings_tabPage.TabIndex = 2;
            this.Settings_tabPage.Text = "Settings";
            this.Settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Help_tabPage
            // 
            this.Help_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Help_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help_tabPage.Name = "Help_tabPage";
            this.Help_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Help_tabPage.TabIndex = 3;
            this.Help_tabPage.Text = "Help";
            this.Help_tabPage.UseVisualStyleBackColor = true;
            // 
            // Add_deviceBox
            // 
            this.Add_deviceBox.BackColor = System.Drawing.SystemColors.Control;
            this.Add_deviceBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_deviceBox.BackgroundImage")));
            this.Add_deviceBox.Location = new System.Drawing.Point(7, 7);
            this.Add_deviceBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Add_deviceBox.Name = "Add_deviceBox";
            this.Add_deviceBox.Size = new System.Drawing.Size(200, 200);
            this.Add_deviceBox.TabIndex = 0;
            this.Add_deviceBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deviceBox1_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 490);
            this.Controls.Add(this.Main_tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Open RGB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Main_tabControl.ResumeLayout(false);
            this.Start_tabPage.ResumeLayout(false);
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
        private deviceBox Add_deviceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

