namespace OpenRGB
{
    partial class ColorSelector
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.red_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.green_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blue_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Hex_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selected_colorBox = new OpenRGB.ColorBox();
            this.red_trackBar = new System.Windows.Forms.TrackBar();
            this.green_trackBar = new System.Windows.Forms.TrackBar();
            this.blue_trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red";
            // 
            // red_numericUpDown
            // 
            this.red_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.red_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.red_numericUpDown.Location = new System.Drawing.Point(40, 124);
            this.red_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red_numericUpDown.Name = "red_numericUpDown";
            this.red_numericUpDown.Size = new System.Drawing.Size(68, 20);
            this.red_numericUpDown.TabIndex = 4;
            this.red_numericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red_numericUpDown.ValueChanged += new System.EventHandler(this.red_numericUpDown_ValueChanged);
            // 
            // green_numericUpDown
            // 
            this.green_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.green_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.green_numericUpDown.Location = new System.Drawing.Point(40, 150);
            this.green_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green_numericUpDown.Name = "green_numericUpDown";
            this.green_numericUpDown.Size = new System.Drawing.Size(68, 20);
            this.green_numericUpDown.TabIndex = 5;
            this.green_numericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green_numericUpDown.ValueChanged += new System.EventHandler(this.green_numericUpDown_ValueChanged);
            // 
            // blue_numericUpDown
            // 
            this.blue_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.blue_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.blue_numericUpDown.Location = new System.Drawing.Point(40, 176);
            this.blue_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue_numericUpDown.Name = "blue_numericUpDown";
            this.blue_numericUpDown.Size = new System.Drawing.Size(68, 20);
            this.blue_numericUpDown.TabIndex = 6;
            this.blue_numericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue_numericUpDown.ValueChanged += new System.EventHandler(this.blue_numericUpDown_ValueChanged);
            // 
            // Hex_textBox
            // 
            this.Hex_textBox.Location = new System.Drawing.Point(40, 98);
            this.Hex_textBox.MaxLength = 6;
            this.Hex_textBox.Name = "Hex_textBox";
            this.Hex_textBox.Size = new System.Drawing.Size(68, 20);
            this.Hex_textBox.TabIndex = 8;
            this.Hex_textBox.Text = "FFFFFF";
            this.Hex_textBox.TextChanged += new System.EventHandler(this.Hex_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "HEX";
            // 
            // selected_colorBox
            // 
            this.selected_colorBox.BackColor = System.Drawing.Color.White;
            this.selected_colorBox.ForeColor = System.Drawing.Color.White;
            this.selected_colorBox.Location = new System.Drawing.Point(19, 10);
            this.selected_colorBox.Margin = new System.Windows.Forms.Padding(10);
            this.selected_colorBox.Name = "selected_colorBox";
            this.selected_colorBox.Size = new System.Drawing.Size(81, 81);
            this.selected_colorBox.TabIndex = 7;
            // 
            // red_trackBar
            // 
            this.red_trackBar.LargeChange = 10;
            this.red_trackBar.Location = new System.Drawing.Point(114, 120);
            this.red_trackBar.Maximum = 255;
            this.red_trackBar.Name = "red_trackBar";
            this.red_trackBar.Size = new System.Drawing.Size(182, 45);
            this.red_trackBar.TabIndex = 10;
            this.red_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.red_trackBar.Scroll += new System.EventHandler(this.red_trackBar_Scroll);
            // 
            // green_trackBar
            // 
            this.green_trackBar.LargeChange = 10;
            this.green_trackBar.Location = new System.Drawing.Point(114, 146);
            this.green_trackBar.Maximum = 255;
            this.green_trackBar.Name = "green_trackBar";
            this.green_trackBar.Size = new System.Drawing.Size(182, 45);
            this.green_trackBar.TabIndex = 11;
            this.green_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.green_trackBar.Scroll += new System.EventHandler(this.green_trackBar_Scroll);
            // 
            // blue_trackBar
            // 
            this.blue_trackBar.LargeChange = 10;
            this.blue_trackBar.Location = new System.Drawing.Point(114, 171);
            this.blue_trackBar.Maximum = 255;
            this.blue_trackBar.Name = "blue_trackBar";
            this.blue_trackBar.Size = new System.Drawing.Size(182, 45);
            this.blue_trackBar.TabIndex = 12;
            this.blue_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blue_trackBar.Scroll += new System.EventHandler(this.blue_trackBar_Scroll);
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.blue_trackBar);
            this.Controls.Add(this.green_trackBar);
            this.Controls.Add(this.red_trackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hex_textBox);
            this.Controls.Add(this.selected_colorBox);
            this.Controls.Add(this.blue_numericUpDown);
            this.Controls.Add(this.green_numericUpDown);
            this.Controls.Add(this.red_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorSelector";
            this.Size = new System.Drawing.Size(300, 200);
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown red_numericUpDown;
        private System.Windows.Forms.NumericUpDown green_numericUpDown;
        private System.Windows.Forms.NumericUpDown blue_numericUpDown;
        private ColorBox selected_colorBox;
        private System.Windows.Forms.TextBox Hex_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar red_trackBar;
        private System.Windows.Forms.TrackBar green_trackBar;
        private System.Windows.Forms.TrackBar blue_trackBar;
    }
}
