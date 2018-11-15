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
            form.OkButtonLeft = 142;
            form.OkButtonVisible = true;
            form.OkButtonFocus();
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            form.OkButtonLeft = 142;
            form.OkButtonVisible = true;
            form.OkButtonFocus();
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    {
                        form.OkButtonLeft = 142;
                        form.OkButtonVisible = true;
                        form.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.OkButtonVisible = true;
                        form.CancelButtonVisible = true;
                        form.CancelButtonFocus();
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.YesButtonVisible = true;
                        form.NoButtonVisible = true;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        form.NoButtonFocus();
                        break;
                    }
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    {
                        form.OkButtonLeft = 142;
                        form.OkButtonVisible = true;
                        form.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.OkButtonVisible = true;
                        form.CancelButtonVisible = true;
                        if (defaultButton == MessageBoxDefaultButton.Button1)
                        {
                            form.OkButtonFocus();
                        }
                        else
                        {
                            form.CancelButtonFocus();
                        }
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.YesButtonVisible = true;
                        form.NoButtonVisible = true;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        if (defaultButton == MessageBoxDefaultButton.Button1)
                        {
                            form.YesButtonFocus();
                        }
                        else
                        {
                            form.NoButtonFocus();
                        }
                        break;
                    }
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxOptions option)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    {
                        form.OkButtonLeft = 142;
                        form.OkButtonVisible = true;
                        form.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.OkButtonVisible = true;
                        form.CancelButtonVisible = true;
                        form.CancelButtonFocus();
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.YesButtonVisible = true;
                        form.NoButtonVisible = true;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        form.NoButtonFocus();
                        break;
                    }
            }
            if ((option & MessageBoxOptions.RtlReading) == MessageBoxOptions.RtlReading)
            {
                form.Rtl = System.Windows.Forms.RightToLeft.Yes;
            }
            if ((option & MessageBoxOptions.RightAlign) == MessageBoxOptions.RightAlign)
            {
                form.RtlLayout = true;
            }
            if ((option & MessageBoxOptions.PersianButtons) == MessageBoxOptions.PersianButtons)
            {
                form.ButtonFarsi();
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton, MessageBoxOptions option)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    {
                        form.OkButtonLeft = 142;
                        form.OkButtonVisible = true;
                        form.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.OkButtonVisible = true;
                        form.CancelButtonVisible = true;
                        if (defaultButton == MessageBoxDefaultButton.Button1)
                        {
                            form.OkButtonFocus();
                        }
                        else
                        {
                            form.CancelButtonFocus();
                        }
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.YesButtonVisible = true;
                        form.NoButtonVisible = true;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        if (defaultButton == MessageBoxDefaultButton.Button1)
                        {
                            form.YesButtonFocus();
                        }
                        else
                        {
                            form.NoButtonFocus();
                        }
                        break;
                    }
            }
            if ((option & MessageBoxOptions.RtlReading) == MessageBoxOptions.RtlReading)
            {
                form.Rtl = System.Windows.Forms.RightToLeft.Yes;
            }
            if ((option & MessageBoxOptions.RightAlign) == MessageBoxOptions.RightAlign)
            {
                form.RtlLayout = true;
            }
            if ((option & MessageBoxOptions.PersianButtons) == MessageBoxOptions.PersianButtons)
            {
                form.ButtonFarsi();
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }
    }
}
