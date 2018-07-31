using System;
using OpenRGBDevices;
using System.Threading;
using LogitechLEDSDK;
using System.Windows.Forms;

namespace OpenRGB
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            LogitechGAPI.LogiLedInit();
        }

        private void deviceBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Configure a new device";
            LogitechGAPI.LogiLedSaveCurrentLighting();
            Thread.Sleep(200);
            int red = 0, green = 100, blue = 100;
            Thread.Sleep(200);
            LogitechGAPI.LogiLedFlashLighting(red, green, blue, 5000, 100);            ;
            LogitechGAPI.LogiLedRestoreLighting();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogitechGAPI.LogiLedShutdown();
        }
    }
}
