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
