namespace Nvd.Windows.Forms
{
    public static class MessageBox
    {
        public static DialogResult Show(string text)
        {
            //return System.Windows.Forms.MessageBox.Show(text:messageText);

            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = " ";
            form.OkButtonVisible = true;
            form.OkButtonLeft = 142;
            form.CancelButtonVisible = false;
            form.YesButtonVisible = false;
            form.NoButtonVisible = false;
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text,string caption)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = caption;
            form.OkButtonVisible = true;
            form.OkButtonLeft = 142;
            form.CancelButtonVisible = false;
            form.YesButtonVisible = false;
            form.NoButtonVisible = false;
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = caption;
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    {
                        form.OkButtonLeft = 142;
                        form.CancelButtonVisible = false;
                        form.YesButtonVisible = false;
                        form.NoButtonVisible = false;
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.YesButtonVisible = false;
                        form.NoButtonVisible = false;
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.OkButtonVisible = false;                        
                        form.CancelButtonVisible = false;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        break;
                    }
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }
    }
}
