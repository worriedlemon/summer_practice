namespace work2
{
    public partial class MainForm : Form
    {
        private readonly TrajectoryParameters parameters;
        private readonly Graphics g;
        private ParametersForm? paramsWindow;

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            parameters = TrajectoryParameters.GetInstance(TrajectoryField.Size.Width / 2, TrajectoryField.Size.Height / 2);
            g = TrajectoryField.CreateGraphics();
        }

        private void ExecuteTool(object sender, EventArgs e)
        {
            double currentAngle = 0;
            int pointsCount = (int)(6.28 / parameters.step) + 1;
            Point[] points = new Point[pointsCount];

            for (int i = (int)(pointsCount * parameters.angle / Math.PI); currentAngle <= 6.28; i = (i + 1) % pointsCount)
            {
                double x, y;
                x = (parameters.radius / 4) * (3 * Math.Cos(currentAngle + 2 * parameters.angle) + Math.Cos(3 * currentAngle + 2 * parameters.angle));
                y = (parameters.radius / 4) * (3 * Math.Sin(currentAngle + 2 * parameters.angle) - Math.Sin(3 * currentAngle + 2 * parameters.angle));
                points[i] = new Point(parameters.centerX + (int)x, parameters.centerY + (int)y);
                currentAngle += parameters.step;
            }

            MoveTriangle(points);
        }

        private void ViewParameters(object sender, EventArgs e)
        {
            if (paramsWindow == null || paramsWindow.IsDisposed)
            {
                paramsWindow = new();
                paramsWindow.CenterXNumeric.Maximum = TrajectoryField.Size.Width;
                paramsWindow.CenterYNumeric.Maximum = TrajectoryField.Size.Height;
                paramsWindow.RadiusNumeric.Maximum = TrajectoryField.Size.Width;
                paramsWindow.Show();
            }
            else paramsWindow.Focus();
        }

        private void CreateInfoPopup(object sender, EventArgs e)
        {
            MessageBox.Show("By double-clicking on a white field (or by clicking Tools - Execute) " +
                "this program will draw a hypocycloid trajectory, which an equilateral triangle will " +
                "be moving along.\nTo change parameters of this movement and other options consider " +
                "clicking Tools - Parameters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (paramsWindow == null) return;
            paramsWindow.CenterXNumeric.Maximum = TrajectoryField.Size.Width;
            paramsWindow.CenterYNumeric.Maximum = TrajectoryField.Size.Height;
            paramsWindow.RadiusNumeric.Maximum = TrajectoryField.Size.Width;
        }

        private void clearFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(TrajectoryField.BackColor);
        }
    }
}