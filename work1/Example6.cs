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
    public partial class Example6 : Form
    {
        private const string RESOURCES_PATH = "C:\\Users\\emils\\Documents\\Visual Studio 2022\\Projects\\summer_practice\\work1\\resources\\";

        private Image NotAScreamer = Image.FromFile(RESOURCES_PATH + "notascreamer.jpg");
        private Image Screamer = Image.FromFile(RESOURCES_PATH + "screamer.jpg");
        int deathCount = 0;

        public Example6()
        {
            InitializeComponent();
        }

        private void Example6_Load(object sender, EventArgs e)
        {
            TotallyNotABait.SizeMode = PictureBoxSizeMode.StretchImage;
            TotallyNotABait.Image = NotAScreamer;
            Label.Font = new Font("Segoi UI", 14, FontStyle.Regular);
        }

        private void TotallyNotABait_MouseHover(object sender, EventArgs e)
        {
            if (deathCount < 0) return;
            deathCount++;
            Label.Text = "Told ya'";
            Label.ForeColor = Color.Red;
            Label.Font = new Font("Impact", 32, FontStyle.Bold);
            TotallyNotABait.Image = Screamer;
            DialogResult result = MessageBox.Show("So, you have chosen death.\nBang!",
                "Gru shot you in the face!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            if (result == DialogResult.Abort) Close();
            else if (result == DialogResult.Retry)
            {
                Label.Text = "You survived " + deathCount + " time(s)";
                Label.Font = new Font("Segoi UI", 14, FontStyle.Regular);
                TotallyNotABait.Image = NotAScreamer;
            }
            else
            {
                Label.Text = "Completely dead";
                deathCount = -1;
            }
        }
    }
}
