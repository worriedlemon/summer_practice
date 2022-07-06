namespace work3
{
    public partial class FractalDrawing : Form
    {
        public FractalTree? fractal;
        private TreeDrawing? tree;
        private Graphics g;
        private Color[] colors;

        public FractalDrawing()
        {
            InitializeComponent();
            g = DrawingField.CreateGraphics();
            CalculateTree();
            colors = new Color[7]
            {
                Color.Gray,
                Color.Blue,
                Color.Green,
                Color.Red,
                Color.Gold,
                Color.Brown,
                Color.Pink
            };
        }

        private int SetInitialRadius(int layerCount)
        {
            double radius = (DrawingField.Size.Width < DrawingField.Size.Height ? DrawingField.Size.Width : DrawingField.Size.Height) * 0.45d;
            double error = 2d / (3 - Math.Pow(3, 1 - layerCount));
            return (int)(radius * error);
        }

        private void CalculateTree()
        {
            Point fieldCenter = new(DrawingField.Size.Width / 2, DrawingField.Size.Height / 2);
            fractal = new FractalTree(fieldCenter);
            int layersCount = (int)DrawLayersNumeric.Maximum;

            Queue<FractalTree.TreeNode> queue = new();
            queue.Enqueue(fractal.root);

            int radius = SetInitialRadius(layersCount);
            int currentLayer = 1;
            int vertexCounter = 0;
            int vertexesCountOnLayer = 6;

            while (currentLayer <= layersCount)
            {
                FractalTree.TreeNode currentNode = queue.Dequeue();
                Point center = currentNode.centerCoordinates;

                for (int currentVertex = 0; currentVertex < 6; currentVertex++)
                {
                    Point vertex = new(
                            (int)(center.X + radius * Math.Sin(Math.PI / 3 * currentVertex)),
                            (int)(center.Y + radius * Math.Cos(Math.PI / 3 * currentVertex))
                        );

                    currentNode.vertexes[currentVertex] = vertex;
                    currentNode.children[currentVertex] = new FractalTree.TreeNode(vertex);
                    if (currentLayer != layersCount) queue.Enqueue(currentNode.children[currentVertex]);
                    vertexCounter++;
                }

                if (vertexCounter == vertexesCountOnLayer)
                {
                    vertexCounter = 0;
                    currentLayer++;
                    vertexesCountOnLayer *= 6;
                    radius /= 3;
                }
            }
        }

        public void DrawFractal(object sender, EventArgs e)
        {
            g.Clear(DrawingField.BackColor);

            Queue<FractalTree.TreeNode> queue = new();
            queue.Enqueue(fractal!.root);

            int currentLayer = 1;
            int vertexCounter = 0;
            int vertexesCountOnLayer = 6;
            int desiredLayer = (int)DrawLayersNumeric.Value;

            while (currentLayer <= desiredLayer)
            {
                FractalTree.TreeNode currentNode = queue.Dequeue();

                for (int currentVertex = 0; currentVertex < 6; currentVertex++)
                    if (currentLayer != desiredLayer)
                        queue.Enqueue(currentNode.children[currentVertex]);
                vertexCounter += 6;

                if (currentLayer == desiredLayer) g.DrawPolygon(new Pen(colors[desiredLayer]), currentNode.vertexes);

                if (vertexCounter == vertexesCountOnLayer)
                {
                    vertexCounter = 0;
                    currentLayer++;
                    vertexesCountOnLayer *= 6;
                }
            }
            return;
        }

        private void DrawTree(object sender, EventArgs e)
        {
            if (tree == null || tree.IsDisposed)
            {
                tree = new TreeDrawing(this, (int)DrawLayersNumeric.Maximum);
                tree.Show();
            }
            else
            {
                tree.Focus();
            }
        }

        private void FractalDrawing_SizeChanged(object sender, EventArgs e)
        {
            g = DrawingField.CreateGraphics();
            CalculateTree();
        }
    }
}