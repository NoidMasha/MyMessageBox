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

        #region OkButton
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
        private void okButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Ok;
            Close();
        }
        #endregion \OkButton

        #region CancelButton
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
        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Cancel;
            Close();
        }
        #endregion \CancelButton

        #region YesButton
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
        private void yesButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Yes;
            Close();
        }
        #endregion \YesButton

        #region NoButton
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
        private void noButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.No;
            Close();
        }
        #endregion \NoButton

        #region AbortButton
        public bool AbortButtonVisible
        {
            set
            {
                abortButton.Visible = value;
            }
        }
        public int AbortButtonLeft
        {
            set
            {
                abortButton.Left = value;
            }
        }
        public void AbortButtonFocus()
        {
            ActiveControl = abortButton;
        }
        private void abortButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Abort;
            Close();
        }
        #endregion \AbortButton

        #region IgnoreButton
        public bool IgnoreButtonVisible
        {
            set
            {
                ignoreButton.Visible = value;
            }
        }
        public int IgnoreButtonLeft
        {
            set
            {
                ignoreButton.Left = value;
            }
        }
        public void IgnoreButtonFocus()
        {
            ActiveControl = ignoreButton;
        }
        private void ignoreButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Ignore;
            Close();
        }
        #endregion \IgnoreButton

        #region RetryButton
        public bool RetryButtonVisible
        {
            set
            {
                retryButton.Visible = value;
            }
        }
        public int RetryButtonLeft
        {
            set
            {
                retryButton.Left = value;
            }
        }
        public void RetryButtonFocus()
        {
            ActiveControl = retryButton;
        }
        private void retryButton_Click(object sender, System.EventArgs e)
        {
            messageBoxResult = Forms.DialogResult.Retry;
            Close();
        }
        #endregion \RetryButton

        public void ButtonFarsi()
        {
            okButton.Text = "اکی";
            cancelButton.Text = "کنسل";
            yesButton.Text = "بلی";
            noButton.Text = "خیر";
            abortButton.Text = "بیخیال";
            ignoreButton.Text = "نادید";
            retryButton.Text = "مجدد";
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
    }
}
