using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Configuration;

namespace OpenRGB
{
    /// <summary>
    /// Control that creates a Color Wheel using the HVS space and allows color selection
    /// </summary>
    class ColorWheel : UserControl
    {
        private int radius;
        private Color _color;

        public int Radius { get => radius; }

        public ColorWheel(int rad = 50)
        {
            radius = rad;
        }

        private void drawWheel()
        {
            Point center = new Point(this.Width / 2, this.Height / 2);
            Graphics g = this.CreateGraphics();
        }
    }
}
