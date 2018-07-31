using System;
using OpenRGBDevices;
using System.Threading;
using LogitechLedCs;
using System.Windows.Forms;

namespace OpenRGB
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            LogitechGSDK.LogiLedInit();
        }

        private void deviceBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Configure a new device";
            LogitechGSDK.LogiLedSaveCurrentLighting();
            Thread.Sleep(200);
            int red = 0, green = 100, blue = 100;
            Thread.Sleep(200);
            LogitechGSDK.LogiLedFlashLighting(red, green, blue, 5000, 100);            ;
            LogitechGSDK.LogiLedRestoreLighting();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogitechGSDK.LogiLedShutdown();
        }
    }
}
