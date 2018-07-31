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

namespace OpenRGB
{
    public partial class deviceBox : UserControl
    {
        private string portName;

        private Color highlightColor = Color.Aqua;

        public string PortName { get => portName; set => portName = value; }

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
    }
}
