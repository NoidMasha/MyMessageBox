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
            result = MessageBox.Show("warning!!! \npress Ok to Exit", "Error", MessageBoxButtons.OkCancel);
            if (result==Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \nare you sure to Exit?", "Error", MessageBoxButtons.YesNo);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("هشدار!!! \nخارج خواهید شد!", "خطا", MessageBoxButtons.Ok, MessageBoxOptions.RtlReading);
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("هشدار!!! \nخارج خواهید شد!", "خطا", MessageBoxButtons.OkCancel, MessageBoxOptions.RtlReading);
            if (result == Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("هشدار!!! \nمیخواهید خارج شوید؟!", "خطا", MessageBoxButtons.YesNo, MessageBoxOptions.RtlReading);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!!", "Error", MessageBoxButtons.Ok, MessageBoxOptions.RightAlign);
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \npress Ok to Exit", "Error", MessageBoxButtons.OkCancel, MessageBoxOptions.RightAlign);
            if (result == Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("warning!!! \nare you sure to Exit?", "Error", MessageBoxButtons.YesNo, MessageBoxOptions.RightAlign);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("هشدار!!! \nخارج خواهید شد!", "خطا", MessageBoxButtons.Ok, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign | MessageBoxOptions.PersianButtons);
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("هشدار!!! \nخارج خواهید شد!", "خطا", MessageBoxButtons.OkCancel, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign | MessageBoxOptions.PersianButtons);
            if (result == Nvd.Windows.Forms.DialogResult.Ok)
            {
                this.Close();
            }
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            result = MessageBox.Show("هشدار!!! \nمیخواهید خارج شوید؟!", "خطا", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign | MessageBoxOptions.PersianButtons);
            if (result == Nvd.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
