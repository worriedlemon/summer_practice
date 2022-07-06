namespace work3
{
    partial class FractalDrawing
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
            this.DrawingField = new System.Windows.Forms.PictureBox();
            this.DrawLayersLabel = new System.Windows.Forms.Label();
            this.DrawLayersNumeric = new System.Windows.Forms.NumericUpDown();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ChooseOnTreeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLayersNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingField
            // 
            this.DrawingField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingField.BackColor = System.Drawing.Color.White;
            this.DrawingField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawingField.Location = new System.Drawing.Point(12, 12);
            this.DrawingField.Name = "DrawingField";
            this.DrawingField.Size = new System.Drawing.Size(500, 500);
            this.DrawingField.TabIndex = 0;
            this.DrawingField.TabStop = false;
            // 
            // DrawLayersLabel
            // 
            this.DrawLayersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawLayersLabel.AutoSize = true;
            this.DrawLayersLabel.Location = new System.Drawing.Point(518, 12);
            this.DrawLayersLabel.Name = "DrawLayersLabel";
            this.DrawLayersLabel.Size = new System.Drawing.Size(112, 20);
            this.DrawLayersLabel.TabIndex = 1;
            this.DrawLayersLabel.Text = "Layers To Draw:";
            // 
            // DrawLayersNumeric
            // 
            this.DrawLayersNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawLayersNumeric.Location = new System.Drawing.Point(518, 46);
            this.DrawLayersNumeric.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DrawLayersNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DrawLayersNumeric.Name = "DrawLayersNumeric";
            this.DrawLayersNumeric.Size = new System.Drawing.Size(172, 27);
            this.DrawLayersNumeric.TabIndex = 2;
            this.DrawLayersNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DrawLayersNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawButton.Location = new System.Drawing.Point(548, 94);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(119, 35);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawFractal);
            // 
            // ChooseOnTreeButton
            // 
            this.ChooseOnTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseOnTreeButton.Location = new System.Drawing.Point(518, 452);
            this.ChooseOnTreeButton.Name = "ChooseOnTreeButton";
            this.ChooseOnTreeButton.Size = new System.Drawing.Size(175, 60);
            this.ChooseOnTreeButton.TabIndex = 4;
            this.ChooseOnTreeButton.Text = "Choose Layer On Tree";
            this.ChooseOnTreeButton.UseVisualStyleBackColor = true;
            this.ChooseOnTreeButton.Click += new System.EventHandler(this.DrawTree);
            // 
            // FractalDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 525);
            this.Controls.Add(this.ChooseOnTreeButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.DrawLayersNumeric);
            this.Controls.Add(this.DrawLayersLabel);
            this.Controls.Add(this.DrawingField);
            this.Name = "FractalDrawing";
            this.Text = "Serpinski Hexagon";
            this.SizeChanged += new System.EventHandler(this.FractalDrawing_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLayersNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DrawingField;
        private Label DrawLayersLabel;
        public NumericUpDown DrawLayersNumeric;
        private Button DrawButton;
        private Button ChooseOnTreeButton;
    }
}