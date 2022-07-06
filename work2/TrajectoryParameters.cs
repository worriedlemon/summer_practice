namespace work2
{
    public class TrajectoryParameters
    {
        private static TrajectoryParameters? instance;

        public enum SpinDirection
        {
            Clockwise = 1,
            Counterclockwise = -1
        }

        // Trajectory parameters
        public int centerX, centerY;
        public int radius;
        public int spinCount;
        public double step;
        public double angle;
        public Color trajectoryColor;
        public float lineThickness;
        public System.Drawing.Drawing2D.DashStyle lineStyle;

        // Movement parameters
        public double startPhase;
        public double endPhase;
        public double relativeVelocity;
        public double spinMomentum;
        public SpinDirection direction;

        // Triangle parameters
        public int triangleSide;
        public Color triangleFillColor;
        public int maxSide, minSide;
        public bool pulsating;
        public double pulsatingSpeed;
        public float contourThickness;
        public System.Drawing.Drawing2D.DashStyle contourStyle;

        private TrajectoryParameters(int centerX, int centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            radius = 200;
            spinCount = 0;
            angle = Math.PI / 6;
            startPhase = 0;
            endPhase = 2 * Math.PI;
            step = 0.05;
            trajectoryColor = Color.Red;
            triangleFillColor = Color.Transparent;
            relativeVelocity = 1;
            spinMomentum = 0.08;
            triangleSide = 50;
            direction = SpinDirection.Clockwise;
            maxSide = 100;
            minSide = 10;
            pulsating = false;
            pulsatingSpeed = 1;
            lineThickness = 1f;
            lineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            contourThickness = 1f;
            contourStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        public static TrajectoryParameters GetInstance(int centerX = 0, int centerY = 0)
        {
            if (instance == null) instance = new(centerX, centerY);
            return instance;
        }
    }
}
