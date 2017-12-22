namespace CsharpGUI
{
    partial class Form1
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
            this.OPEN = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BrightnessValue = new System.Windows.Forms.TrackBar();
            this.GreyScale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessValue)).BeginInit();
            this.SuspendLayout();
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(12, 12);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(75, 23);
            this.OPEN.TabIndex = 0;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(12, 41);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(567, 366);
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // BrightnessValue
            // 
            this.BrightnessValue.BackColor = System.Drawing.SystemColors.Control;
            this.BrightnessValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrightnessValue.Location = new System.Drawing.Point(33, 441);
            this.BrightnessValue.Maximum = 100;
            this.BrightnessValue.Minimum = -100;
            this.BrightnessValue.Name = "BrightnessValue";
            this.BrightnessValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrightnessValue.Size = new System.Drawing.Size(455, 45);
            this.BrightnessValue.TabIndex = 5;
            this.BrightnessValue.TickFrequency = 10;
            this.BrightnessValue.Scroll += new System.EventHandler(this.BrightnessValue_Scroll);
            // 
            // GreyScale
            // 
            this.GreyScale.Location = new System.Drawing.Point(106, 12);
            this.GreyScale.Name = "GreyScale";
            this.GreyScale.Size = new System.Drawing.Size(75, 23);
            this.GreyScale.TabIndex = 6;
            this.GreyScale.Text = "GreyScale";
            this.GreyScale.UseVisualStyleBackColor = true;
            this.GreyScale.Click += new System.EventHandler(this.GreyScale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 487);
            this.Controls.Add(this.GreyScale);
            this.Controls.Add(this.BrightnessValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.OPEN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar BrightnessValue;
        private System.Windows.Forms.Button GreyScale;
    }
}

