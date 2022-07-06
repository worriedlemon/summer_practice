using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work3
{
    public partial class TreeDrawing : Form
    {
        private readonly FractalDrawing parent;
        private PictureBox? treePicture;
        private FractalTree tree;
        private readonly int layersCount;
        private Button[] buttons;
        private Graphics g;
        private Color[] colors;

        int nodeSize = 40;
        int nodeDistance = 60;

        public TreeDrawing(FractalDrawing parent, int layersCount)
        {
            InitializeComponent();
            this.parent = parent;
            this.tree = parent.fractal!;
            this.layersCount = layersCount;
            this.buttons = new Button[layersCount];
            InitializeTreePicture();
            g = treePicture!.CreateGraphics();
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

        public void ShowTree()
        {
            tree = parent.fractal!;
            g.Clear(treePicture!.BackColor);

            Queue<FractalTree.TreeNode> queue = new();
            queue.Enqueue(tree.root);

            int currentLayer = 0;
            int vertexCounter = 0;
            int vertexesCountOnLayer = 1;

            int nodeDistanceX = nodeSize + 5, nodeDistanceY = 3 * nodeSize / 2;

            int ellipseX = 0, ellipseY = 0;
            int parentY = 0;
            Point textPoint = new(ellipseX + nodeSize / 5, ellipseY + nodeSize / 5);

            while (currentLayer <= layersCount)
            {
                Pen pen = new Pen(colors[currentLayer])
                {
                    Width = 3
                };
                FractalTree.TreeNode currentNode = queue.Dequeue();
                g.DrawEllipse(pen, ellipseX, ellipseY, nodeSize, nodeSize);
                g.DrawString($"{currentNode.centerCoordinates.X}\n{currentNode.centerCoordinates.Y}",
                    new Font("Cambria Math", 8), Brushes.DarkGray, textPoint);

                for (int currentVertex = 0; currentVertex < 6; currentVertex++)
                    if (currentLayer != layersCount)
                        queue.Enqueue(currentNode.children[currentVertex]);

                if (currentLayer != 0 && vertexCounter <= 15)
                {
                    g.DrawLine(Pens.Black, nodeSize / 2, parentY - (nodeDistanceY - nodeSize), ellipseX + nodeSize / 2, ellipseY);
                }

                vertexCounter++;

                if (vertexCounter == vertexesCountOnLayer)
                {
                    vertexCounter = 0;
                    currentLayer++;
                    vertexesCountOnLayer *= 6;
                    ellipseX = 0;
                    ellipseY += nodeDistanceY;
                    textPoint.X = nodeSize / 5;
                    textPoint.Y += nodeDistanceY;
                    if (currentLayer != 0)
                    {
                        parentY += nodeDistanceY;
                    }
                }
                else
                {
                    ellipseX += nodeDistanceX;
                    textPoint.X += nodeDistanceX;
                }
            }
        }

        private void InitializeTreePicture()
        {
            treePicture = new()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right),
                Location = new Point(145, 12),
                Name = "TreePicture",
                Size = new Size(643, 426),
                TabIndex = 0,
                TabStop = false,
                WaitOnLoad = true
            };

            treePicture.Click += new EventHandler(ChooseLayer!);

            Controls.Add(treePicture);
        }

        private void ShowButtons()
        {
            int offset = 12;
            int offsetY = 0;
            int sizeX = 125;
            for (int currentLayer = 0; currentLayer <= layersCount; currentLayer++)
            {
                if (currentLayer == 0)
                {
                    Label auxLabel = new()
                    {
                        Location = new Point(offset, offset),
                        Size = new Size(sizeX, nodeSize),
                        Font = new Font("Segoi UI", 8),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = "Fractal Center Point:",
                        Anchor = (AnchorStyles.Top | AnchorStyles.Left)
                    };

                    Controls.Add(auxLabel);
                    currentLayer++;
                }

                offsetY += nodeDistance;

                buttons[currentLayer - 1] = new()
                {
                    Location = new Point(offset, offset + offsetY),
                    Size = new Size(sizeX, nodeSize),
                    Text = $"Show Layer {currentLayer}",
                    AccessibleDescription = currentLayer.ToString(),
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left)
                };

                buttons[currentLayer - 1].Click += new EventHandler(SetLayer!);

                Controls.Add(buttons[currentLayer - 1]);
            }
        }

        private void SetLayer(object sender, EventArgs e)
        {
            parent.DrawLayersNumeric.Value = Convert.ToInt32(((Button)sender).AccessibleDescription);
            parent.DrawFractal(sender, e);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ShowButtons();
            ShowTree();
        }

        private void ChooseLayer(object sender, EventArgs e)
        {
            Point currentPosition = new(
                MousePosition.X - this.Location.X - treePicture!.Location.X - 9,
                MousePosition.Y - this.Location.Y - treePicture!.Location.Y - 38
                );

            int field = layersCount * nodeSize + (nodeDistance - nodeSize) * (layersCount - 2);
            int layer = currentPosition.Y * nodeSize / field / (layersCount + 1);
            if (layer == 0 || layer > 6) return;

            parent.DrawLayersNumeric.Value = layer;
            parent.DrawFractal(sender, e);
        }
    }
}
