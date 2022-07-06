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
    public partial class Example2 : Form
    {
        public Example2()
        {
            InitializeComponent();
        }

        private void ShowMBButton_Click(object sender, EventArgs e)
        {
            string calculatedAge = (BirthyearNumeric.Maximum - BirthyearNumeric.Value).ToString();
            MessageBox.Show("Hello, " + NameTextBox.Text + "! Your age is around " + calculatedAge + " years old.", "Message");
        }

        private void Example2_Load(object sender, EventArgs e)
        {
            BirthyearToolTip.SetToolTip(BirthyearNumeric, "Enter here your year of birth");
            NameToolTip.SetToolTip(NameTextBox, "Enter here your name");
        }
    }
}
