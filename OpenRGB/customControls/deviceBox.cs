using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenRGB.Devices;

namespace OpenRGB
{
    public partial class deviceBox : UserControl
    {
        protected string argument;
        private Devices.DeviceType type;

        private Color highlightColor = Color.Aqua;


        public string Argument { get => argument; set => argument = value; }
        public DeviceType Type { get => type; set => type = value; }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.BackgroundImage, new Rectangle(0, 0, this.Width, this.Height));
        }

        public deviceBox()
        {
            InitializeComponent();
        }
        
        private void deviceBox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = highlightColor;
        }

        private void deviceBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
        }

        private void deviceBox_Load(object sender, EventArgs e)
        {

        }
    }
}
