namespace work1
{
    public partial class TrajectoryTest : Form
    {
        private Pen trajectoryColor = Pens.Red;
        private Pen contourColor = Pens.Black;

        public TrajectoryTest()
        {
            InitializeComponent();
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            // Editable parametres
            double spinCount = 1;
            double step = 0.05, currentAngle = 0;
            int centerX = 250, centerY = 250;
            int k = 20;
            int radiusBig = 200;

            // Calculated parametres
            double endPoint = 6.3 * spinCount;
            double x, y, x1, y1;
            int radiusSmall = radiusBig / k;

            Point[] points = new Point[(int)(endPoint / step) + 2];

            for (int i = 0; currentAngle <= endPoint; i++)
            {
                x = radiusSmall * (k - 1) * (Math.Cos(currentAngle) + Math.Cos((k - 1) * currentAngle) / (k - 1));
                y = radiusSmall * (k - 1) * (Math.Sin(currentAngle) - Math.Sin((k - 1) * currentAngle) / (k - 1));
                points[i] = new Point(centerX + (int)x, centerY + (int)y);
                PaintGraphics(centerX, centerY, radiusBig, x, y, points);
                x1 = (radiusBig - radiusSmall) * Math.Sin(currentAngle + 1.57);
                y1 = (radiusBig - radiusSmall) * Math.Cos(currentAngle + 1.57);
                PaintCircle(centerX, centerY, (int)x1, (int)y1, radiusSmall, (int)x, (int)y);
                currentAngle += step;
                Thread.Sleep(30);
            }
        }

        private void PaintGraphics(int centerX, int centerY, int radiusBig, double x, double y, Point[] points)
        {
            Graphics g = TrajectoryField.CreateGraphics();
            g.Clear(TrajectoryField.BackColor);
            PaintCircle(centerX, centerY, 0, 0, radiusBig, (int)x, (int)y);
            g.DrawLines(trajectoryColor, points);
        }

        private void PaintCircle(int centerX, int centerY, int centerX1, int centerY1, int radius, int x, int y)
        {
            Graphics g = TrajectoryField.CreateGraphics();
            g.DrawEllipse(contourColor, centerX + centerX1 - radius, centerY - centerY1 - radius, radius * 2, radius * 2);
            g.DrawLine(contourColor, centerX + centerX1, centerY - centerY1, centerX + x, centerY + y);
        }
    }
}
