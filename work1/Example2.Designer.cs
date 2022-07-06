namespace work1
{
    partial class Example2
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.BirthyearNumeric = new System.Windows.Forms.NumericUpDown();
            this.ShowMBButton = new System.Windows.Forms.Button();
            this.BirthyearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BirthyearNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(95, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Enter your name";
            this.NameTextBox.Size = new System.Drawing.Size(355, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BirthYearLabel
            // 
            this.BirthYearLabel.AutoSize = true;
            this.BirthYearLabel.Location = new System.Drawing.Point(14, 60);
            this.BirthYearLabel.Name = "BirthYearLabel";
            this.BirthYearLabel.Size = new System.Drawing.Size(75, 20);
            this.BirthYearLabel.TabIndex = 2;
            this.BirthYearLabel.Text = "Birth year:";
            // 
            // BirthyearNumeric
            // 
            this.BirthyearNumeric.Location = new System.Drawing.Point(95, 58);
            this.BirthyearNumeric.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.BirthyearNumeric.Minimum = new decimal(new int[] {
            1901,
            0,
            0,
            0});
            this.BirthyearNumeric.Name = "BirthyearNumeric";
            this.BirthyearNumeric.Size = new System.Drawing.Size(355, 27);
            this.BirthyearNumeric.TabIndex = 3;
            this.BirthyearNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BirthyearNumeric.Value = new decimal(new int[] {
            1901,
            0,
            0,
            0});
            // 
            // ShowMBButton
            // 
            this.ShowMBButton.Location = new System.Drawing.Point(138, 116);
            this.ShowMBButton.Name = "ShowMBButton";
            this.ShowMBButton.Size = new System.Drawing.Size(191, 52);
            this.ShowMBButton.TabIndex = 4;
            this.ShowMBButton.Text = "Show Message";
            this.ShowMBButton.UseVisualStyleBackColor = true;
            this.ShowMBButton.Click += new System.EventHandler(this.ShowMBButton_Click);
            // 
            // BirthyearToolTip
            // 
            this.BirthyearToolTip.IsBalloon = true;
            // 
            // NameToolTip
            // 
            this.NameToolTip.IsBalloon = true;
            // 
            // Example2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 193);
            this.Controls.Add(this.ShowMBButton);
            this.Controls.Add(this.BirthyearNumeric);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "Example2";
            this.Text = "Example 2";
            this.Load += new System.EventHandler(this.Example2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BirthyearNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Label BirthYearLabel;
        private NumericUpDown BirthyearNumeric;
        private Button ShowMBButton;
        private ToolTip BirthyearToolTip;
        private ToolTip NameToolTip;
    }
}