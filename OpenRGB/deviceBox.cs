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
        private Color highlightColor = Color.Aqua;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.BackgroundImage, new Rectangle(0, 0, this.Width, this.Height));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Debug.WriteLine("mouse enter!");
            this.BackColor = highlightColor;
            this.Refresh();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Debug.WriteLine("mouse leave!");
            this.BackColor = this.Parent.BackColor;
            this.Refresh();
            base.OnMouseLeave(e);
        }

        public deviceBox()
        {
            InitializeComponent();
        }

        private void deviceBox_Click(object sender, EventArgs e)
        {

        }
    }
}
