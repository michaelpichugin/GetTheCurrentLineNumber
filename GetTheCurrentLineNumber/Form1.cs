using System.Runtime.CompilerServices;

namespace GetTheCurrentLineNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage("test");
        }
        static void ShowMessage(string message, [CallerLineNumber] int lineNumber = 0)
        {
            MessageBox.Show("line " + lineNumber + ": " + message);
        }
    }
}