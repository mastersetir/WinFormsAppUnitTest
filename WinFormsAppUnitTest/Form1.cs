using MyMset.ExtensionMethods;

namespace WinFormsAppUnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = string.Format( " Word Count {0} ", textBox1.Text.WordCount().ToString());
        }
    }
}
