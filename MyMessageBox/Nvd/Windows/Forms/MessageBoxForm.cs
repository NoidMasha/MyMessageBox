namespace Nvd.Windows.Forms
{
    public partial class MessageBoxForm : System.Windows.Forms.Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        public string MessageText { get; set; }
        public string Caption
        {
            set
            {
                this.Text = value;
            }
        }
        public bool OkButtonVisible
        {
            set
            {
                okButton.Visible = value;
            }
        }
        public int OkButtonLeft
        {
            set
            {
                okButton.Left = value;
            }
        }
        public void OkButtonFocus()
        {
            ActiveControl = okButton;
        }
        public bool CancelButtonVisible
        {
            set
            {
                cancelButton.Visible = value;
            }
        }
        public int CancelButtonLeft
        {
            set
            {
                cancelButton.Left = value;
            }
        }
        public void CancelButtonFocus()
        {
            ActiveControl = cancelButton;
        }
        public bool YesButtonVisible
        {
            set
            {
                yesButton.Visible = value;
            }
        }
        public int YesButtonLeft
        {
            set
            {
                yesButton.Left = value;
            }
        }
        public void YesButtonFocus()
        {
            ActiveControl = yesButton;
        }
        public bool NoButtonVisible
        {
            set
            {
                noButton.Visible = value;
            }
        }
        public int NoButtonLeft
        {
            set
            {
                noButton.Left = value;
            }
        }
        public void NoButtonFocus()
        {
            ActiveControl =  noButton;
        }
        public void ButtonFarsi()
        {
            okButton.Text = "اکی";
            cancelButton.Text = "کنسل";
            yesButton.Text = "بلی";
            noButton.Text = "خیر";
        }
        private DialogResult messageBoxResult;
        public DialogResult MessageBoxResult
        {
            get
            {
                return messageBoxResult;
            }
        }

        private void MessageBoxForm_Load(object sender, System.EventArgs e)
        {
            textLabel.Text = MessageText;
        }

        public System.Windows.Forms.RightToLeft Rtl
        {
            set
            {
                textLabel.RightToLeft = value;
            }
        }

        public bool RtlLayout
        {
            set
            {
                if (value) { this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; }
                else { this.RightToLeft = System.Windows.Forms.RightToLeft.No; }
                this.RightToLeftLayout = value; ;
            }
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Ok;
            Close();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Cancel;
            Close();
        }

        private void noButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.No;
            Close();
        }

        private void yesButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Yes;
            Close();
        }
    }
}
