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
            Console.WriteLine(AdvancedColors.FromHSV(2.1f, 0.7f, 0.7f).R);
            Console.WriteLine(AdvancedColors.FromHSV(2.1f, 0.7f, 0.7f).G);
            Console.WriteLine(AdvancedColors.FromHSV(2.1f, 0.7f, 0.7f).B);
        }

        private void deviceBox1_MouseClick(object sender, MouseEventArgs e)
        {
            colorForm color = new colorForm();
            color.Show();
            label1.Text = "Set up a new device...";
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Clear();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Button Addbutton = new Button();
            Addbutton.Text = "Add device";
            Addbutton.FlatStyle = FlatStyle.Flat;
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
