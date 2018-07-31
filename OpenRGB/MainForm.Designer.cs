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
            this.deviceBox1 = new OpenRGB.deviceBox();
            this.Settings_tabPage = new System.Windows.Forms.TabPage();
            this.Help_tabPage = new System.Windows.Forms.TabPage();
            this.Help_webBrowser = new System.Windows.Forms.WebBrowser();
            this.Main_tabControl.SuspendLayout();
            this.Devices_tabPage.SuspendLayout();
            this.Help_tabPage.SuspendLayout();
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
            this.Start_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Start_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_tabPage.Name = "Start_tabPage";
            this.Start_tabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Start_tabPage.TabIndex = 0;
            this.Start_tabPage.Text = "Start";
            this.Start_tabPage.UseVisualStyleBackColor = true;
            // 
            // Devices_tabPage
            // 
            this.Devices_tabPage.Controls.Add(this.deviceBox1);
            this.Devices_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Devices_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Devices_tabPage.Name = "Devices_tabPage";
            this.Devices_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Devices_tabPage.TabIndex = 1;
            this.Devices_tabPage.Text = "Devices";
            this.Devices_tabPage.UseVisualStyleBackColor = true;
            // 
            // deviceBox1
            // 
            this.deviceBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceBox1.BackgroundImage")));
            this.deviceBox1.Location = new System.Drawing.Point(7, 7);
            this.deviceBox1.Margin = new System.Windows.Forms.Padding(7);
            this.deviceBox1.Name = "deviceBox1";
            this.deviceBox1.Size = new System.Drawing.Size(150, 150);
            this.deviceBox1.TabIndex = 0;
            // 
            // Settings_tabPage
            // 
            this.Settings_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Settings_tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings_tabPage.Name = "Settings_tabPage";
            this.Settings_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Settings_tabPage.TabIndex = 2;
            this.Settings_tabPage.Text = "Settings";
            this.Settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // Help_tabPage
            // 
            this.Help_tabPage.Controls.Add(this.Help_webBrowser);
            this.Help_tabPage.Location = new System.Drawing.Point(25, 4);
            this.Help_tabPage.Name = "Help_tabPage";
            this.Help_tabPage.Size = new System.Drawing.Size(906, 462);
            this.Help_tabPage.TabIndex = 3;
            this.Help_tabPage.Text = "Help";
            this.Help_tabPage.UseVisualStyleBackColor = true;
            // 
            // Help_webBrowser
            // 
            this.Help_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Help_webBrowser.Location = new System.Drawing.Point(0, 0);
            this.Help_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Help_webBrowser.Name = "Help_webBrowser";
            this.Help_webBrowser.Size = new System.Drawing.Size(906, 462);
            this.Help_webBrowser.TabIndex = 0;
            this.Help_webBrowser.Url = new System.Uri("https://github.com/Dany-Boy55/OpenRGB/wiki", System.UriKind.Absolute);
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
            this.Main_tabControl.ResumeLayout(false);
            this.Devices_tabPage.ResumeLayout(false);
            this.Help_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Main_tabControl;
        private System.Windows.Forms.TabPage Start_tabPage;
        private System.Windows.Forms.TabPage Devices_tabPage;
        private System.Windows.Forms.TabPage Settings_tabPage;
        private deviceBox deviceBox1;
        private System.Windows.Forms.TabPage Help_tabPage;
        private System.Windows.Forms.WebBrowser Help_webBrowser;
    }
}

