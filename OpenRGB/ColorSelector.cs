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
            SelectedColorChanged?.Invoke(this, e);
        }

        public ColorSelector()
        {
            InitializeComponent();
        }        

        private void red_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            red = (int)red_numericUpDown.Value;
            selectedColor = Color.FromArgb(red, green, blue);
            //hexColor[0] = '0'; 
            selected_colorBox.BackColor = selectedColor;
            OnSelectedColorChange(new SelectedColorChangedEventArgs(selectedColor));
        }

        private void green_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            green = (int)green_numericUpDown.Value;
            selectedColor = Color.FromArgb(red, green, blue);
            selected_colorBox.BackColor = selectedColor;
            OnSelectedColorChange(new SelectedColorChangedEventArgs(selectedColor));
        }

        private void blue_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            blue = (int)blue_numericUpDown.Value;
            selectedColor = Color.FromArgb(red, green, blue);
            selected_colorBox.BackColor = selectedColor;
            OnSelectedColorChange(new SelectedColorChangedEventArgs(selectedColor));
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
