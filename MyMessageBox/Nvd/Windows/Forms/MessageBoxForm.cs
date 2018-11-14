namespace Nvd.Windows.Forms
{
    public partial class MessageBoxForm : System.Windows.Forms.Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        public string MessageText { get; set; }

        private void MessageBoxForm_Load(object sender, System.EventArgs e)
        {
            //textLabel.Text = MessageText;
        }


    }
}
