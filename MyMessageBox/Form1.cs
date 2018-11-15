using Nvd.Windows.Forms;
namespace MyMessageBox
{
    
    public partial class Form1 : System.Windows.Forms.Form
    {
        private DialogResult result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            result =  MessageBox.Show("warning!");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!", "Error");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!!", "Error", MessageBoxButtons.Ok);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \n press Ok to Exit", "Error", MessageBoxButtons.OkCancel);
            if (result==Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \n are you sure to Exit?", "Error", MessageBoxButtons.YesNo);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!!", "Error", MessageBoxButtons.Ok, MessageBoxDefaultButton.Button1);
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \n press Ok to Exit", "Error", MessageBoxButtons.OkCancel, MessageBoxDefaultButton.Button1);
            if (result == Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \n are you sure to Exit?", "Error", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button1);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!!", "Error", MessageBoxButtons.Ok, MessageBoxDefaultButton.Button2);
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \n press Ok to Exit", "Error", MessageBoxButtons.OkCancel, MessageBoxDefaultButton.Button2);
            if (result == Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \n are you sure to Exit?", "Error", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button3);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
