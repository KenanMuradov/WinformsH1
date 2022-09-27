namespace BakuAndLondon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityChangeButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityChangeButton
            // 
            this.cityChangeButton.AutoSize = true;
            this.cityChangeButton.Location = new System.Drawing.Point(12, 12);
            this.cityChangeButton.Name = "cityChangeButton";
            this.cityChangeButton.Size = new System.Drawing.Size(82, 25);
            this.cityChangeButton.TabIndex = 0;
            this.cityChangeButton.Text = "Change City";
            this.cityChangeButton.UseVisualStyleBackColor = true;
            this.cityChangeButton.Click += new System.EventHandler(this.cityChangeButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(288, 17);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(73, 15);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "CurrentTime";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakuAndLondon.Properties.Resources.Baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 473);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.cityChangeButton);
            this.Name = "Form1";
            this.Text = "Baku And London Times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cityChangeButton;
        private Label timeLabel;
    }
}