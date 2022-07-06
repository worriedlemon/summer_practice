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
    public partial class Example4 : Form
    {
        private const string RESOURCES_PATH = "C:\\Users\\emils\\Documents\\Visual Studio 2022\\Projects\\summer_practice\\work1\\resources\\";
        public Example4()
        {
            InitializeComponent();
        }

        private void Example4_Load(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = RESOURCES_PATH + "test_text.txt";
            OpenFileDialog.Filter = "Text files(*.txt)|*.txt|All files|*.*";
            SaveFileDialog.Filter = OpenFileDialog.Filter;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileName == null || OpenFileDialog.FileName == "") return;
            try
            {
                StreamReader fileReader = new(OpenFileDialog.FileName, Encoding.UTF8);
                TextBox.Text = fileReader.ReadToEnd();
                fileReader.Close();
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message + "\nFile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = OpenFileDialog.FileName;
            if (SaveFileDialog.ShowDialog() == DialogResult.OK) SaveFile();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Example4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TextBox.Modified) return;
            DialogResult MessageResult = MessageBox.Show("Text happens to be modified.\nSave changes?",
                "File is modified", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (MessageResult)
            {
                case DialogResult.Yes:
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK) SaveFile();
                    else e.Cancel = true;
                    return;
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void SaveFile()
        {
            try
            {
                StreamWriter fileWriter = new(SaveFileDialog.FileName, false, Encoding.UTF8);
                fileWriter.Write(TextBox.Text);
                fileWriter.Close();
                TextBox.Modified = false;
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
