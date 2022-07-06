namespace work1
{
    partial class TrajectoryTest
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
            this.TrajectoryField = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectoryField)).BeginInit();
            this.SuspendLayout();
            // 
            // TrajectoryField
            // 
            this.TrajectoryField.BackColor = System.Drawing.Color.White;
            this.TrajectoryField.Location = new System.Drawing.Point(12, 12);
            this.TrajectoryField.Name = "TrajectoryField";
            this.TrajectoryField.Size = new System.Drawing.Size(500, 500);
            this.TrajectoryField.TabIndex = 0;
            this.TrajectoryField.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(528, 240);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start Animation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartAnimation);
            // 
            // TrajectoryTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 523);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TrajectoryField);
            this.Name = "TrajectoryTest";
            this.Text = "Trajectory Test";
            ((System.ComponentModel.ISupportInitialize)(this.TrajectoryField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox TrajectoryField;
        private Button StartButton;
    }
}