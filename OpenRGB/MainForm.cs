using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRGB
{
    public partial class MainForm : Form
    {
        private ColorSelector selector;

        public MainForm()
        {
            InitializeComponent();
            selector = new ColorSelector();
            selector.SelectedColor = Color.Aqua;
            Form selectform = new Form();
            selectform.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            selectform.Icon = this.Icon;
            selectform.Controls.Add(selector);
            selectform.Show();
        }

        private void colorSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
        }
    }
}
