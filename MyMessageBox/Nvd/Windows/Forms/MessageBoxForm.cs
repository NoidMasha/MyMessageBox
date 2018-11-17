namespace Nvd.Windows.Forms
{
    public partial class MessageBoxForm : System.Windows.Forms.Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The text that will be shown in body of messagebox
        /// </summary>
        public string MessageText { get; set; }

        /// <summary>
        /// The title of the messagebox form
        /// </summary>
        public string Caption
        {
            set
            {
                this.Text = value;
            }
        }

        #region OkButton

        /// <summary>
        /// The visibility of okButton, if true => visible
        /// </summary>
        public bool OkButtonVisible
        {
            set
            {
                okButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of okButton
        /// </summary>
        public int OkButtonLeft
        {
            set
            {
                okButton.Left = value;
            }
        }

        /// <summary>
        /// Calling this method puts focus on okButton 
        /// </summary>
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

        /// <summary>
        /// The visibility of cancelButton, if true => visible
        /// </summary>
        public bool CancelButtonVisible
        {
            set
            {
                cancelButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of cancelButton
        /// </summary>
        public int CancelButtonLeft
        {
            set
            {
                cancelButton.Left = value;
            }
        }

        /// <summary>
        /// Calling this method puts focus on cancelButton 
        /// </summary>
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

        /// <summary>
        /// The visibility of yesButton, if true => visible
        /// </summary>
        public bool YesButtonVisible
        {
            set
            {
                yesButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of yesButton
        /// </summary>
        public int YesButtonLeft
        {
            set
            {
                yesButton.Left = value;
            }
        }

        /// <summary>
        /// Calling this method puts focus on yesButton 
        /// </summary>
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

        /// <summary>
        /// The visibility of noButton, if true => visible
        /// </summary>
        public bool NoButtonVisible
        {
            set
            {
                noButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of noButton
        /// </summary>
        public int NoButtonLeft
        {
            set
            {
                noButton.Left = value;
            }
        }
        /// <summary>
        /// Calling this method puts focus on noButton 
        /// </summary>
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

        /// <summary>
        /// The visibility of abortButton, if true => visible
        /// </summary>
        public bool AbortButtonVisible
        {
            set
            {
                abortButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of abortButton
        /// </summary>
        public int AbortButtonLeft
        {
            set
            {
                abortButton.Left = value;
            }
        }

        /// <summary>
        /// Calling this method puts focus on abortButton 
        /// </summary>
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

        /// <summary>
        /// The visibility of ignoreButton, if true => visible
        /// </summary>
        public bool IgnoreButtonVisible
        {
            set
            {
                ignoreButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of ignoreButton
        /// </summary>
        public int IgnoreButtonLeft
        {
            set
            {
                ignoreButton.Left = value;
            }
        }

        /// <summary>
        /// Calling this method puts focus on ignoreButton 
        /// </summary>
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

        /// <summary>
        /// The visibility of retryButton, if true => visible
        /// </summary>
        public bool RetryButtonVisible
        {
            set
            {
                retryButton.Visible = value;
            }
        }

        /// <summary>
        /// The X position of retryButton
        /// </summary>
        public int RetryButtonLeft
        {
            set
            {
                retryButton.Left = value;
            }
        }

        /// <summary>
        /// Calling this method puts focus on retryButton 
        /// </summary>
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

        /// <summary>
        /// This method converts all controls text to Persian
        /// </summary>
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
        /// <summary>
        /// The result of messagebox that indicates which button is clicked
        /// </summary>
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

        /// <summary>
        /// This property makes the text RTL and it's preferd for RTL languages like Persian
        /// </summary>
        public System.Windows.Forms.RightToLeft Rtl
        {
            set
            {
                textLabel.RightToLeft = value;
            }
        }

        /// <summary>
        /// This property makes the layout of the form to Right To Left, if true => RTL
        /// </summary>
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
