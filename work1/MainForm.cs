using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using work1;

namespace work1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonToEx1_Click(object sender, EventArgs e)
        {
            Example1 ex = new();
            ex.Show();
        }

        private void ButtonToEx2_Click(object sender, EventArgs e)
        {
            Example2 ex = new();
            ex.Show();
        }

        private void ButtonToEx3_Click(object sender, EventArgs e)
        {
            Example3 ex = new();
            ex.Show();
        }

        private void ButtonToEx4_Click(object sender, EventArgs e)
        {
            Example4 ex = new();
            ex.Show();
        }

        private void ButtonToEx5_Click(object sender, EventArgs e)
        {
            Example5 ex = new();
            ex.Show();
        }

        private void ButtonToEx6_Click(object sender, EventArgs e)
        {
            Example6 ex = new();
            ex.Show();
        }

        private void ButtonToTrajectory_Click(object sender, EventArgs e)
        {
            TrajectoryTest ex = new();
            ex.Show();
        }
    }
}
