using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRGB
{
    /// <summary>
    /// Simple control for displaying/storing a color (like a textbox for color)
    /// </summary>
    class ColorBox : UserControl
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(new Point(0,0), this.Size));
            g.FillRectangle(new SolidBrush(this.ForeColor), new Rectangle(5, 5, this.Width - 10, this.Height - 10));
            //base.OnPaint(e);
        }
        
        #region Constructors
        public ColorBox()
        {
            this.ForeColor = Color.White;
            this.Margin = new Padding(8);
        }
        #endregion
    }
}
