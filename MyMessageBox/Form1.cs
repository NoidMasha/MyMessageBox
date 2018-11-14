using Nvd.Windows.Forms;
namespace MyMessageBox
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("warning!!!");
        }
    }
}
