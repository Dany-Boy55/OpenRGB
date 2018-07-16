using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRGB
{
    class ColorBox : UserControl
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

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
