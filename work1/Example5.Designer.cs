namespace work1
{
    partial class Example5
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.PlaceFigureButton = new System.Windows.Forms.Button();
            this.TableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.y3 = new System.Windows.Forms.NumericUpDown();
            this.x3 = new System.Windows.Forms.NumericUpDown();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.FigureType = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.FillColor = new System.Windows.Forms.ComboBox();
            this.CoordinatesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.TableGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(564, 426);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // PlaceFigureButton
            // 
            this.PlaceFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceFigureButton.Location = new System.Drawing.Point(582, 400);
            this.PlaceFigureButton.Name = "PlaceFigureButton";
            this.PlaceFigureButton.Size = new System.Drawing.Size(206, 38);
            this.PlaceFigureButton.TabIndex = 1;
            this.PlaceFigureButton.Text = "Place Figure";
            this.PlaceFigureButton.UseVisualStyleBackColor = true;
            this.PlaceFigureButton.Click += new System.EventHandler(this.PlaceFigureButton_Click);
            // 
            // TableGrid
            // 
            this.TableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGrid.ColumnCount = 2;
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableGrid.Controls.Add(this.y3, 1, 2);
            this.TableGrid.Controls.Add(this.x3, 0, 2);
            this.TableGrid.Controls.Add(this.y2, 1, 1);
            this.TableGrid.Controls.Add(this.x2, 0, 1);
            this.TableGrid.Controls.Add(this.y1, 1, 0);
            this.TableGrid.Controls.Add(this.x1, 0, 0);
            this.TableGrid.Location = new System.Drawing.Point(582, 223);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.RowCount = 3;
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableGrid.Size = new System.Drawing.Size(206, 166);
            this.TableGrid.TabIndex = 2;
            // 
            // y3
            // 
            this.y3.Enabled = false;
            this.y3.Location = new System.Drawing.Point(106, 113);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(97, 27);
            this.y3.TabIndex = 5;
            // 
            // x3
            // 
            this.x3.Enabled = false;
            this.x3.Location = new System.Drawing.Point(3, 113);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(97, 27);
            this.x3.TabIndex = 4;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(106, 58);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(97, 27);
            this.y2.TabIndex = 3;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(3, 58);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(97, 27);
            this.x2.TabIndex = 2;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(106, 3);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(97, 27);
            this.y1.TabIndex = 1;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(3, 3);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(97, 27);
            this.x1.TabIndex = 0;
            // 
            // FigureType
            // 
            this.FigureType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FigureType.FormattingEnabled = true;
            this.FigureType.Location = new System.Drawing.Point(585, 53);
            this.FigureType.Name = "FigureType";
            this.FigureType.Size = new System.Drawing.Size(200, 28);
            this.FigureType.TabIndex = 3;
            this.FigureType.SelectedIndexChanged += new System.EventHandler(this.FigureType_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(585, 26);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(137, 20);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Choose figure type:";
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(585, 96);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(163, 20);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Choose figure fill color:";
            // 
            // FillColor
            // 
            this.FillColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FillColor.FormattingEnabled = true;
            this.FillColor.Location = new System.Drawing.Point(585, 122);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(200, 28);
            this.FillColor.TabIndex = 6;
            this.FillColor.SelectedIndexChanged += new System.EventHandler(this.FillColor_SelectedIndexChanged);
            // 
            // CoordinatesLabel
            // 
            this.CoordinatesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordinatesLabel.AutoSize = true;
            this.CoordinatesLabel.Location = new System.Drawing.Point(585, 200);
            this.CoordinatesLabel.Name = "CoordinatesLabel";
            this.CoordinatesLabel.Size = new System.Drawing.Size(92, 20);
            this.CoordinatesLabel.TabIndex = 7;
            this.CoordinatesLabel.Text = "Coordinates:";
            // 
            // Example5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoordinatesLabel);
            this.Controls.Add(this.FillColor);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.FigureType);
            this.Controls.Add(this.TableGrid);
            this.Controls.Add(this.PlaceFigureButton);
            this.Controls.Add(this.Canvas);
            this.Name = "Example5";
            this.Text = "Example 5";
            this.Load += new System.EventHandler(this.Example5_Load);
            this.SizeChanged += new System.EventHandler(this.Example5_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.TableGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Canvas;
        private Button PlaceFigureButton;
        private TableLayoutPanel TableGrid;
        private NumericUpDown y3;
        private NumericUpDown y2;
        private NumericUpDown x2;
        private NumericUpDown y1;
        private NumericUpDown x1;
        private ComboBox FigureType;
        private Label TypeLabel;
        private NumericUpDown x3;
        private Label ColorLabel;
        private ComboBox FillColor;
        private Label CoordinatesLabel;
    }
}