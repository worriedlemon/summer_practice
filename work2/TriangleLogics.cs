using System.Drawing.Drawing2D;

namespace work2
{
    public partial class MainForm
    {
        private static Point[] InitializeTriangle(Point center, double spinAngle, int tempSize)
        {
            double r0 = tempSize / Math.Sqrt(3);
            return new Point[3]
            {
                new Point(center.X + (int)(r0 * Math.Cos(spinAngle)), center.Y + (int)(r0 * Math.Sin(spinAngle))),
                new Point(center.X + (int)(r0 * Math.Cos(2 * Math.PI / 3 + spinAngle)), center.Y + (int)(r0 * Math.Sin(2 * Math.PI / 3 + spinAngle))),
                new Point(center.X + (int)(r0 * Math.Cos(4 * Math.PI / 3 + spinAngle)), center.Y + (int)(r0 * Math.Sin(4 * Math.PI / 3 + spinAngle)))
            };
        }

        private void MoveTriangle(Point[] centers)
        {
            double currentAngle, spinAngle = 0, absoluteLatency = 2000 / centers.Length;

            // Start index
            int index = (centers.Length - (int)(centers.Length * parameters.startPhase / (2d * Math.PI))) % centers.Length;

            // Distance to cover
            double distance = 2 * Math.PI * parameters.spinCount + parameters.startPhase;
            if (parameters.direction == TrajectoryParameters.SpinDirection.Clockwise)
                distance += 1 + (parameters.endPhase + parameters.startPhase - 1) % (2 * Math.PI);
            else distance += Math.Abs(parameters.endPhase - parameters.startPhase);

            // Pulsating
            int pulsatingSize = parameters.triangleSide;
            bool up = true;

            // Calculating
            for (currentAngle = parameters.startPhase; currentAngle <= distance; currentAngle += parameters.step)
            {
                g.Clear(TrajectoryField.BackColor);

                Pen trajectoryPen = new(parameters.trajectoryColor) {
                    Width = parameters.lineThickness,
                    DashStyle = parameters.lineStyle
                }, trianglePen = new(Color.Black) {
                    Width = parameters.contourThickness,
                    DashStyle = parameters.contourStyle
                };

                Point[] triangleCoords = InitializeTriangle(centers[index], spinAngle, pulsatingSize);

                g.DrawPolygon(trajectoryPen, centers);
                g.DrawPolygon(trianglePen, triangleCoords);
                g.FillPolygon(new SolidBrush(parameters.triangleFillColor), triangleCoords);

                index = (index + (int)parameters.direction) % centers.Length;
                if (index < 0) index += centers.Length;
                spinAngle += Math.PI / 4 * parameters.spinMomentum;

                if (parameters.pulsating)
                {
                    if (pulsatingSize > parameters.maxSide - parameters.pulsatingSpeed * 5) up = false;
                    if (pulsatingSize < parameters.minSide + parameters.pulsatingSpeed * 5) up = true;
                    pulsatingSize += (int)(parameters.pulsatingSpeed * 5 * (up ? 1 : -1));
                }

                Thread.Sleep((int)(absoluteLatency / parameters.relativeVelocity));
            }
            return;
        }
    }
}
