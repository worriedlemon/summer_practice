namespace work1
{
    partial class Example3
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
            this.PictureChooser = new System.Windows.Forms.ComboBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TextToAppear = new System.Windows.Forms.TextBox();
            this.ShowTextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureChooser
            // 
            this.PictureChooser.FormattingEnabled = true;
            this.PictureChooser.Items.AddRange(new object[] {
            "-- (Empty)",
            "Bank",
            "Building",
            "City",
            "Train"});
            this.PictureChooser.Location = new System.Drawing.Point(579, 13);
            this.PictureChooser.Name = "PictureChooser";
            this.PictureChooser.Size = new System.Drawing.Size(209, 28);
            this.PictureChooser.TabIndex = 5;
            this.PictureChooser.SelectedIndexChanged += new System.EventHandler(this.PictureChooser_SelectedIndexChanged);
            // 
            // PictureLabel
            // 
            this.PictureLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PictureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PictureLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PictureLabel.Location = new System.Drawing.Point(12, 394);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(556, 44);
            this.PictureLabel.TabIndex = 4;
            this.PictureLabel.Text = "{picture_name}";
            this.PictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(12, 13);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(556, 369);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // TextToAppear
            // 
            this.TextToAppear.Location = new System.Drawing.Point(579, 71);
            this.TextToAppear.Multiline = true;
            this.TextToAppear.Name = "TextToAppear";
            this.TextToAppear.PlaceholderText = "Enter something...";
            this.TextToAppear.Size = new System.Drawing.Size(209, 311);
            this.TextToAppear.TabIndex = 6;
            this.TextToAppear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowTextButton
            // 
            this.ShowTextButton.Location = new System.Drawing.Point(579, 394);
            this.ShowTextButton.Name = "ShowTextButton";
            this.ShowTextButton.Size = new System.Drawing.Size(209, 44);
            this.ShowTextButton.TabIndex = 7;
            this.ShowTextButton.Text = "Show Text";
            this.ShowTextButton.UseVisualStyleBackColor = true;
            this.ShowTextButton.Click += new System.EventHandler(this.ShowTextButton_Click);
            // 
            // Example3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowTextButton);
            this.Controls.Add(this.TextToAppear);
            this.Controls.Add(this.PictureChooser);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.PictureBox);
            this.Name = "Example3";
            this.Text = "Example 3";
            this.Load += new System.EventHandler(this.Example3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox PictureChooser;
        private Label PictureLabel;
        private PictureBox PictureBox;
        private TextBox TextToAppear;
        private Button ShowTextButton;
    }
}