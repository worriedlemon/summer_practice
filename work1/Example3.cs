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
    public partial class Example3 : Form
    {
        private const string RESOURCES_PATH = "C:\\Users\\emils\\Documents\\Visual Studio 2022\\Projects\\summer_practice\\work1\\resources\\";
        public Example3()
        {
            InitializeComponent();
        }

        private void PictureChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PictureChooser.SelectedIndex)
            {
                case 0:
                    PictureBox.Image = null;
                    PictureLabel.Text = "Firstly, choose picture";
                    break;
                case 1:
                    PictureBox.Image = Image.FromFile(RESOURCES_PATH + "bank.jpg");
                    PictureLabel.Text = "Bank";
                    break;
                case 2:
                    PictureBox.Image = Image.FromFile(RESOURCES_PATH + "building.jpg");
                    PictureLabel.Text = "Building";
                    break;
                case 3:
                    PictureBox.Image = Image.FromFile(RESOURCES_PATH + "city.jpg");
                    PictureLabel.Text = "City";
                    break;
                case 4:
                    PictureBox.Image = Image.FromFile(RESOURCES_PATH + "train.jpg");
                    PictureLabel.Text = "Train";
                    break;
            }
        }

        private void Example3_Load(object sender, EventArgs e)
        {
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureLabel.Text = "Firstly, choose picture";
            PictureChooser.Text = "-- (Empty)";
        }

        private void ShowTextButton_Click(object sender, EventArgs e)
        {
            String text = TextToAppear.Text;
            Brush brush = new SolidBrush(Color.Cyan);
            Graphics G = PictureBox.CreateGraphics();
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            G.DrawString(text, new Font("Segoe Script", 14, FontStyle.Bold), brush, 20, 20);
        }
    }
}
