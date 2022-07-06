namespace work2
{
    partial class MainForm
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
            this.ToolsMenu = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrajectoryField = new System.Windows.Forms.PictureBox();
            this.ToolsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectoryField)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ToolsMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(622, 28);
            this.ToolsMenu.TabIndex = 0;
            this.ToolsMenu.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.clearFieldToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.parametersToolStripMenuItem.Text = "Parameters...";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.ViewParameters);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.ExecuteTool);
            // 
            // clearFieldToolStripMenuItem
            // 
            this.clearFieldToolStripMenuItem.Name = "clearFieldToolStripMenuItem";
            this.clearFieldToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.clearFieldToolStripMenuItem.Text = "Clear Field";
            this.clearFieldToolStripMenuItem.Click += new System.EventHandler(this.clearFieldToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.CreateInfoPopup);
            // 
            // TrajectoryField
            // 
            this.TrajectoryField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrajectoryField.BackColor = System.Drawing.Color.White;
            this.TrajectoryField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrajectoryField.Location = new System.Drawing.Point(11, 30);
            this.TrajectoryField.Margin = new System.Windows.Forms.Padding(2);
            this.TrajectoryField.Name = "TrajectoryField";
            this.TrajectoryField.Size = new System.Drawing.Size(600, 600);
            this.TrajectoryField.TabIndex = 1;
            this.TrajectoryField.TabStop = false;
            this.TrajectoryField.DoubleClick += new System.EventHandler(this.ExecuteTool);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 638);
            this.Controls.Add(this.TrajectoryField);
            this.Controls.Add(this.ToolsMenu);
            this.MainMenuStrip = this.ToolsMenu;
            this.Name = "MainForm";
            this.Text = "Trajectory Seeker 2D";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ToolsMenu.ResumeLayout(false);
            this.ToolsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectoryField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip ToolsMenu;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem parametersToolStripMenuItem;
        private ToolStripMenuItem executeToolStripMenuItem;
        private PictureBox TrajectoryField;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem clearFieldToolStripMenuItem;
    }
}