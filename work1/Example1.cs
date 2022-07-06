namespace work1
{
    public partial class Example1 : Form
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textDisplay.Text = "";
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textInput.Text;
        }
    }
}