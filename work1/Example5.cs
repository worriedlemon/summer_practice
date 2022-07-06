using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work1
{
    public partial class Example5 : Form
    {
        enum FigureEnumType
        {
            Line,
            Ellipse,
            Triangle,
            Rectangle
        }

        private FigureEnumType selectedType = FigureEnumType.Line;
        private Color paintColor = Color.Transparent;
        private readonly int[] CoordinatesX = new int[3];
        private readonly int[] CoordinatesY = new int[3];

        public Example5()
        {
            InitializeComponent();
        }

        private void FigureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = (FigureEnumType)FigureType.SelectedIndex;
            if (selectedType != FigureEnumType.Triangle)
                x3.Enabled = y3.Enabled = false;
            else
                x3.Enabled = y3.Enabled = true;
        }

        private void Example5_SizeChanged(object sender, EventArgs e)
        {
            x1.Maximum = x2.Maximum = x3.Maximum = Canvas.Size.Width;
            y1.Maximum = y2.Maximum = y3.Maximum = Canvas.Size.Height;
        }

        private void Example5_Load(object sender, EventArgs e)
        {
            x1.Maximum = x2.Maximum = x3.Maximum = Canvas.Size.Width;
            y1.Maximum = y2.Maximum = y3.Maximum = Canvas.Size.Height;
            FigureType.Items.AddRange(Enum.GetNames(typeof(FigureEnumType)));
            FigureType.Text = "Line";
            FillColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
            FillColor.Text = "Transparent";
        }

        private void PlaceFigureButton_Click(object sender, EventArgs e)
        {
            Canvas.CreateGraphics().Clear(SystemColors.Control);
            CoordinatesX[0] = (int)x1.Value;
            CoordinatesX[1] = (int)x2.Value;
            CoordinatesX[2] = (int)x3.Value;
            CoordinatesY[0] = (int)y1.Value;
            CoordinatesY[1] = (int)y2.Value;
            CoordinatesY[2] = (int)y3.Value;
            Canvas.Refresh();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Brush fill = new SolidBrush(paintColor);
            if (selectedType == FigureEnumType.Line || selectedType == FigureEnumType.Triangle)
            {
                e.Graphics.DrawLine(Pens.Blue, CoordinatesX[0], CoordinatesY[0], CoordinatesX[1], CoordinatesY[1]);
                if (selectedType == FigureEnumType.Triangle)
                {
                    Point[] points = new Point[3] {
                        new Point(CoordinatesX[0], CoordinatesY[0]),
                        new Point(CoordinatesX[1], CoordinatesY[1]),
                        new Point(CoordinatesX[2], CoordinatesY[2])
                    };
                    e.Graphics.DrawLine(Pens.Blue, CoordinatesX[1], CoordinatesY[1], CoordinatesX[2], CoordinatesY[2]);
                    e.Graphics.DrawLine(Pens.Blue, CoordinatesX[2], CoordinatesY[2], CoordinatesX[0], CoordinatesY[0]);
                    e.Graphics.FillPolygon(fill, points);
                }
            }
            else if (selectedType == FigureEnumType.Ellipse)
            {
                e.Graphics.DrawEllipse(Pens.Blue, CoordinatesX[0], CoordinatesY[0], CoordinatesX[1], CoordinatesY[1]);
                e.Graphics.FillEllipse(fill, CoordinatesX[0], CoordinatesY[0], CoordinatesX[1], CoordinatesY[1]);
            }
            else
            {
                e.Graphics.DrawRectangle(Pens.Blue, CoordinatesX[0], CoordinatesY[0], CoordinatesX[1], CoordinatesY[1]);
                e.Graphics.FillRectangle(fill, CoordinatesX[0], CoordinatesY[0], CoordinatesX[1], CoordinatesY[1]);
            }
        }

        private void FillColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            paintColor = Color.FromKnownColor((KnownColor)(FillColor.SelectedIndex + 1));
        }
    }
}
