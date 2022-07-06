namespace work1
{
    partial class Example6
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
            this.TotallyNotABait = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotallyNotABait)).BeginInit();
            this.SuspendLayout();
            // 
            // TotallyNotABait
            // 
            this.TotallyNotABait.Location = new System.Drawing.Point(12, 12);
            this.TotallyNotABait.Name = "TotallyNotABait";
            this.TotallyNotABait.Size = new System.Drawing.Size(426, 426);
            this.TotallyNotABait.TabIndex = 0;
            this.TotallyNotABait.TabStop = false;
            this.TotallyNotABait.MouseHover += new System.EventHandler(this.TotallyNotABait_MouseHover);
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(446, 12);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(344, 426);
            this.Label.TabIndex = 1;
            this.Label.Text = "<-- Do not hover over it";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Example6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TotallyNotABait);
            this.Name = "Example6";
            this.Text = "Example 6";
            this.Load += new System.EventHandler(this.Example6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotallyNotABait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox TotallyNotABait;
        private Label Label;
    }
}