using System;
using System.Windows.Forms;
using System.Drawing;
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
        #region Constructors
        public ColorBox()
        {
            this.BackColor = Color.White;
            this.Size = new Size(64,64);
            this.Margin = new Padding(10);
        }
        #endregion
    }
}
