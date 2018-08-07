using System;
using OpenRGB.Devices;
using System.Threading;
using LogiLedSDK;
using System.Windows.Forms;

namespace OpenRGB
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void deviceBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Configure a new device";
            LogiLEDAPI.LogiLedSaveCurrentLighting();
            Thread.Sleep(200);
            int red = 0, green = 100, blue = 100;
            Thread.Sleep(200);
            LogiLEDAPI.LogiLedFlashLighting(red, green, blue, 5000, 100);            ;
            LogiLEDAPI.LogiLedRestoreLighting();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogiLEDAPI.LogiLedShutdown();
        }
    }
}
