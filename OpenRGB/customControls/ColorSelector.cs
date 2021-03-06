﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenRGB
{   

    public partial class ColorSelector : UserControl
    {

        private Color selectedColor;
        private int red = 255, green = 255, blue = 255, hue, sat, val;
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

        /// <summary>
        /// Constructor for the object
        /// </summary>
        public ColorSelector()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with a defined default color
        /// </summary>
        /// <param name="defaultColor">Default color </param>
        public ColorSelector(Color defaultColor)
        {
            InitializeComponent();
            selectedColor = defaultColor;
        }

        /// <summary>
        /// Called when the user inputs a color into the Hex color textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hex_textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Hex_textBox.Text.Length == 6)
            {
                this.selectedColor = AdvancedColors.HexStringToColor(this.Hex_textBox.Text);
                this.red_numericUpDown.Value = this.selectedColor.R;
                this.green_numericUpDown.Value = this.selectedColor.G;
                this.blue_numericUpDown.Value = this.selectedColor.B;
                OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
            }
        }

        /// <summary>
        /// Called when the user changes the value of the numeric box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void red_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.red = (int)this.red_numericUpDown.Value;
            this.red_trackBar.Value = red;
            this.selectedColor = Color.FromArgb(red, green, blue);
            this.hexColor = AdvancedColors.ColorToHex(this.SelectedColor);
            this.Hex_textBox.Text = this.hexColor;
            this.Hue_numericUpDown.Value = (int)(this.selectedColor.GetHue());
            this.Sat_numericUpDown.Value = (int)(this.selectedColor.GetSaturation() * 100);
            this.Val_numericUpDown.Value = (int)(this.selectedColor.GetBrightness() * 100);
            OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
        }

        /// <summary>
        /// Called when the user changes the value of the numeric box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void green_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.green = (int)this.green_numericUpDown.Value;
            this.green_trackBar.Value = green;
            this.selectedColor = Color.FromArgb(red, green, blue);
            this.hexColor = AdvancedColors.ColorToHex(this.SelectedColor);
            this.Hex_textBox.Text = this.hexColor;
            this.Hue_numericUpDown.Value = (int)(this.selectedColor.GetHue());
            this.Sat_numericUpDown.Value = (int)(this.selectedColor.GetSaturation() * 100);
            this.Val_numericUpDown.Value = (int)(this.selectedColor.GetBrightness() * 100);
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
            this.blue_trackBar.Value = blue;
            this.selectedColor = Color.FromArgb(red, green, blue);
            this.hexColor = AdvancedColors.ColorToHex(this.SelectedColor);
            this.Hex_textBox.Text = this.hexColor;
            this.Hue_numericUpDown.Value = (int)(this.selectedColor.GetHue());
            this.Sat_numericUpDown.Value = (int)(this.selectedColor.GetSaturation() * 100);
            this.Val_numericUpDown.Value = (int)(this.selectedColor.GetBrightness() * 100);
            OnSelectedColorChange(new SelectedColorChangedEventArgs(this.selectedColor));
        }

        private void Hue_trackBar_Scroll(object sender, EventArgs e)
        {
            hue = Hue_trackBar.Value;
        }

        private void Sat_trackBar_Scroll(object sender, EventArgs e)
        {
            sat = Sat_trackBar.Value;
        }

        private void Val_trackBar_Scroll(object sender, EventArgs e)
        {
            val = Val_trackBar.Value;
        }

        /// <summary>
        /// Called when the user uses the red trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void red_trackBar_Scroll(object sender, EventArgs e)
        {
            this.red = red_trackBar.Value;
            this.selectedColor = Color.FromArgb(red, green, blue);
            this.red_numericUpDown.Value = red;
        }

        /// <summary>
        /// Called when the user uses the green trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void green_trackBar_Scroll(object sender, EventArgs e)
        {
            this.green = green_trackBar.Value;
            this.selectedColor = Color.FromArgb(green, green, blue);
            this.green_numericUpDown.Value = green;
        }

        /// <summary>
        /// Called when the user uses the blue trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blue_trackBar_Scroll(object sender, EventArgs e)
        {
            this.blue = blue_trackBar.Value;
            this.selectedColor = Color.FromArgb(red, green, blue);
            this.blue_numericUpDown.Value = blue;
        }

        /// <summary>
        /// Called when the user clicks on the hue color wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(wheel_pictureBox.Image);
            Point p = new Point((int)(wheel_pictureBox.Width * 0.25), (int)(wheel_pictureBox.Height * 0.25));
            Size s = new Size((int)(wheel_pictureBox.Width * 0.25), (int)(wheel_pictureBox.Height * 0.25));
            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(p, s));

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
