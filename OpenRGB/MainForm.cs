using System;
using OpenRGB.Devices;
using OpenRGB;
using System.Threading;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
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
            label1.Text = "Set up a new device...";
            comboBox1.Items.Clear();
            foreach (string item in Enum.GetNames(typeof(Devices.DeviceType)))
            {
                comboBox1.Items.Add(item);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(devices != null)
            {
                
            }

        }
    }
}
