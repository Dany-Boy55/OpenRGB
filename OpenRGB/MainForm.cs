using System;
using OpenRGB.Devices;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace OpenRGB
{
    public partial class MainForm : Form
    {

        public GenericDevice devices;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void deviceBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var dev = new LogitechMouse();
            dev.Interval = 500;
            dev.MainColor = Color.AliceBlue;
            Thread.Sleep(200);
            dev.WriteEffect(Effect.Flash);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(devices != null)
            {
                
            }

        }
    }
}
