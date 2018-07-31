namespace OpenRGB
{
    partial class colorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorForm));
            this.colorSelector1 = new OpenRGB.ColorSelector();
            this.SuspendLayout();
            // 
            // colorSelector1
            // 
            this.colorSelector1.Location = new System.Drawing.Point(12, 12);
            this.colorSelector1.Name = "colorSelector1";
            this.colorSelector1.SelectedColor = System.Drawing.Color.Empty;
            this.colorSelector1.Size = new System.Drawing.Size(300, 200);
            this.colorSelector1.TabIndex = 0;
            // 
            // colorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 223);
            this.Controls.Add(this.colorSelector1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "colorForm";
            this.Text = "Color Picker";
            this.ResumeLayout(false);

        }

        #endregion

        private ColorSelector colorSelector1;
    }
}