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
            this.red_trackBar = new System.Windows.Forms.TrackBar();
            this.green_trackBar = new System.Windows.Forms.TrackBar();
            this.blue_trackBar = new System.Windows.Forms.TrackBar();
            this.wheel_pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Hue_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Sat_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Val_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Hue_trackBar = new System.Windows.Forms.TrackBar();
            this.Sat_trackBar = new System.Windows.Forms.TrackBar();
            this.Val_trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheel_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hue_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sat_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hue_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sat_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red";
            // 
            // red_numericUpDown
            // 
            this.red_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.red_numericUpDown.Location = new System.Drawing.Point(214, 5);
            this.red_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.red_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red_numericUpDown.Name = "red_numericUpDown";
            this.red_numericUpDown.Size = new System.Drawing.Size(56, 22);
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
            this.green_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.green_numericUpDown.Location = new System.Drawing.Point(214, 35);
            this.green_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.green_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green_numericUpDown.Name = "green_numericUpDown";
            this.green_numericUpDown.Size = new System.Drawing.Size(56, 22);
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
            this.blue_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.blue_numericUpDown.Location = new System.Drawing.Point(214, 65);
            this.blue_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.blue_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue_numericUpDown.Name = "blue_numericUpDown";
            this.blue_numericUpDown.Size = new System.Drawing.Size(56, 22);
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
            this.Hex_textBox.Location = new System.Drawing.Point(50, 209);
            this.Hex_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hex_textBox.MaxLength = 6;
            this.Hex_textBox.Name = "Hex_textBox";
            this.Hex_textBox.Size = new System.Drawing.Size(105, 22);
            this.Hex_textBox.TabIndex = 8;
            this.Hex_textBox.Text = "FFFFFF";
            this.Hex_textBox.TextChanged += new System.EventHandler(this.Hex_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "HEX";
            // 
            // red_trackBar
            // 
            this.red_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.red_trackBar.LargeChange = 10;
            this.red_trackBar.Location = new System.Drawing.Point(369, 5);
            this.red_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.red_trackBar.Maximum = 255;
            this.red_trackBar.Name = "red_trackBar";
            this.red_trackBar.Size = new System.Drawing.Size(171, 56);
            this.red_trackBar.TabIndex = 10;
            this.red_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.red_trackBar.Scroll += new System.EventHandler(this.red_trackBar_Scroll);
            // 
            // green_trackBar
            // 
            this.green_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.green_trackBar.LargeChange = 10;
            this.green_trackBar.Location = new System.Drawing.Point(369, 37);
            this.green_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.green_trackBar.Maximum = 255;
            this.green_trackBar.Name = "green_trackBar";
            this.green_trackBar.Size = new System.Drawing.Size(171, 56);
            this.green_trackBar.TabIndex = 11;
            this.green_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.green_trackBar.Scroll += new System.EventHandler(this.green_trackBar_Scroll);
            // 
            // blue_trackBar
            // 
            this.blue_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blue_trackBar.LargeChange = 10;
            this.blue_trackBar.Location = new System.Drawing.Point(369, 69);
            this.blue_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.blue_trackBar.Maximum = 255;
            this.blue_trackBar.Name = "blue_trackBar";
            this.blue_trackBar.Size = new System.Drawing.Size(171, 56);
            this.blue_trackBar.TabIndex = 12;
            this.blue_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blue_trackBar.Scroll += new System.EventHandler(this.blue_trackBar_Scroll);
            // 
            // wheel_pictureBox
            // 
            this.wheel_pictureBox.Image = global::OpenRGB.Properties.Resources.ColorWheel;
            this.wheel_pictureBox.Location = new System.Drawing.Point(0, -1);
            this.wheel_pictureBox.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.wheel_pictureBox.Name = "wheel_pictureBox";
            this.wheel_pictureBox.Size = new System.Drawing.Size(200, 200);
            this.wheel_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wheel_pictureBox.TabIndex = 13;
            this.wheel_pictureBox.TabStop = false;
            this.wheel_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Saturation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Value";
            // 
            // Hue_numericUpDown
            // 
            this.Hue_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Hue_numericUpDown.Location = new System.Drawing.Point(214, 95);
            this.Hue_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Hue_numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Hue_numericUpDown.Name = "Hue_numericUpDown";
            this.Hue_numericUpDown.Size = new System.Drawing.Size(56, 22);
            this.Hue_numericUpDown.TabIndex = 17;
            this.Hue_numericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Sat_numericUpDown
            // 
            this.Sat_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Sat_numericUpDown.Location = new System.Drawing.Point(214, 125);
            this.Sat_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Sat_numericUpDown.Name = "Sat_numericUpDown";
            this.Sat_numericUpDown.Size = new System.Drawing.Size(56, 22);
            this.Sat_numericUpDown.TabIndex = 18;
            this.Sat_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Val_numericUpDown
            // 
            this.Val_numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Val_numericUpDown.Location = new System.Drawing.Point(214, 155);
            this.Val_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Val_numericUpDown.Name = "Val_numericUpDown";
            this.Val_numericUpDown.Size = new System.Drawing.Size(56, 22);
            this.Val_numericUpDown.TabIndex = 19;
            this.Val_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Hue_trackBar
            // 
            this.Hue_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hue_trackBar.LargeChange = 10;
            this.Hue_trackBar.Location = new System.Drawing.Point(369, 101);
            this.Hue_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.Hue_trackBar.Maximum = 255;
            this.Hue_trackBar.Name = "Hue_trackBar";
            this.Hue_trackBar.Size = new System.Drawing.Size(171, 56);
            this.Hue_trackBar.TabIndex = 20;
            this.Hue_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Hue_trackBar.Scroll += new System.EventHandler(this.Hue_trackBar_Scroll);
            // 
            // Sat_trackBar
            // 
            this.Sat_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sat_trackBar.LargeChange = 10;
            this.Sat_trackBar.Location = new System.Drawing.Point(369, 133);
            this.Sat_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.Sat_trackBar.Maximum = 255;
            this.Sat_trackBar.Name = "Sat_trackBar";
            this.Sat_trackBar.Size = new System.Drawing.Size(171, 56);
            this.Sat_trackBar.TabIndex = 21;
            this.Sat_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Sat_trackBar.Scroll += new System.EventHandler(this.Sat_trackBar_Scroll);
            // 
            // Val_trackBar
            // 
            this.Val_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Val_trackBar.LargeChange = 10;
            this.Val_trackBar.Location = new System.Drawing.Point(369, 165);
            this.Val_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.Val_trackBar.Maximum = 255;
            this.Val_trackBar.Name = "Val_trackBar";
            this.Val_trackBar.Size = new System.Drawing.Size(171, 56);
            this.Val_trackBar.TabIndex = 22;
            this.Val_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Val_trackBar.Scroll += new System.EventHandler(this.Val_trackBar_Scroll);
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Val_trackBar);
            this.Controls.Add(this.Sat_trackBar);
            this.Controls.Add(this.Hue_trackBar);
            this.Controls.Add(this.Val_numericUpDown);
            this.Controls.Add(this.Sat_numericUpDown);
            this.Controls.Add(this.Hue_numericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wheel_pictureBox);
            this.Controls.Add(this.blue_trackBar);
            this.Controls.Add(this.green_trackBar);
            this.Controls.Add(this.red_trackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hex_textBox);
            this.Controls.Add(this.blue_numericUpDown);
            this.Controls.Add(this.green_numericUpDown);
            this.Controls.Add(this.red_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorSelector";
            this.Size = new System.Drawing.Size(544, 351);
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheel_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hue_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sat_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hue_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sat_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val_trackBar)).EndInit();
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
        private System.Windows.Forms.TextBox Hex_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar red_trackBar;
        private System.Windows.Forms.TrackBar green_trackBar;
        private System.Windows.Forms.TrackBar blue_trackBar;
        private System.Windows.Forms.PictureBox wheel_pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Hue_numericUpDown;
        private System.Windows.Forms.NumericUpDown Sat_numericUpDown;
        private System.Windows.Forms.NumericUpDown Val_numericUpDown;
        private System.Windows.Forms.TrackBar Hue_trackBar;
        private System.Windows.Forms.TrackBar Sat_trackBar;
        private System.Windows.Forms.TrackBar Val_trackBar;
    }
}
