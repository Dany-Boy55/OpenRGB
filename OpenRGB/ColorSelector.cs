using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenRGB
{   

    public partial class ColorSelector : UserControl
    {

        private Color selectedColor;
        private int red = 255, green = 255, blue = 255;
        private string hexColor = "FFFFFF";

        public Color SelectedColor { get => selectedColor; set => selectedColor = value; }

        /// <summary>
        /// Custom event raised when the user selects a new color
        /// </summary>
        public event EventHandler<SelectedColorChangedEventArgs> SelectedColorChanged;        

        /// <summary>
        /// Internally called when the user selects a new color, triggers SelectedColorChanged event
        /// </summary>
        /// <param name="e">SelectedColorChangedEventArgs to pass along a Color object</param>
        protected virtual void OnSelectedColorChange(SelectedColorChangedEventArgs e)
        {
            this.selectedColor = Color.FromArgb(red, green, blue);
            this.selected_colorBox.ForeColor = this.selectedColor;
            this.hexColor = AdvancedColors.ColorToHex(this.SelectedColor);
            this.Hex_textBox.Text = this.hexColor;
            SelectedColorChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Constructor for the object
        /// </summary>
        public ColorSelector()
        {
            InitializeComponent();
        }        

        /// <summary>
        /// Called when the user changes the value of the numeric box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void red_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.red = (int)this.red_numericUpDown.Value;
            OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
        }

        private void Hex_textBox_TextChanged(object sender, EventArgs e)
        {
            if(this.Hex_textBox.Text.Length == 6)
            {
                this.selectedColor = AdvancedColors.HexToColor(this.Hex_textBox.Text);
                OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
            }
        }

        /// <summary>
        /// Called when the user changes the value of the numeric box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void green_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.green = (int)this.green_numericUpDown.Value;
            OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
        }

        /// <summary>
        /// Called when the user changes the value of the numeric box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blue_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.blue = (int)this.blue_numericUpDown.Value;
            OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
        }
    }

    /// <summary>
    /// Defines the arguments passed when the SelectedColorChanged Event is raised
    /// </summary>
    public class SelectedColorChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Color selected by the user to pass as an argument
        /// </summary>
        public Color selected { get; set; }

        /// <summary>
        /// Initializes a new empty instance of the class
        /// </summary>
        public SelectedColorChangedEventArgs() { }

        /// <summary>
        /// initializes a new instance of the class with the specified color to pass as an argument
        /// </summary>
        /// <param name="color"></param>
        public SelectedColorChangedEventArgs(Color color)
        {
            selected = color;
        }
    }

}
