namespace Nvd.Windows.Forms
{
    public static class MessageBox
    {
        private static void buttonsHandle(MessageBoxForm frm,MessageBoxButtons btns)
        {
            switch (btns)
            {
                case MessageBoxButtons.Ok:
                    {
                        frm.OkButtonLeft = 142;
                        frm.OkButtonVisible = true;
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        frm.OkButtonVisible = true;
                        frm.CancelButtonVisible = true;
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        frm.YesButtonVisible = true;
                        frm.NoButtonVisible = true;
                        frm.NoButtonLeft = 272;
                        frm.YesButtonLeft = 196;
                        break;
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        frm.RetryButtonLeft = 272;
                        frm.CancelButtonLeft = 196;
                        frm.RetryButtonVisible = true;
                        frm.CancelButtonVisible = true;
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        frm.YesButtonVisible = true;
                        frm.NoButtonVisible = true;
                        frm.CancelButtonVisible = true;
                        frm.YesButtonLeft = 142;
                        frm.NoButtonLeft = 218;
                        frm.CancelButtonLeft = 66;
                        break;
                    }
                case MessageBoxButtons.AbortRetryIgnore:
                    {
                        frm.AbortButtonVisible = true;
                        frm.RetryButtonVisible = true;
                        frm.IgnoreButtonVisible = true;
                        frm.AbortButtonLeft = 66;
                        frm.RetryButtonLeft = 142;
                        frm.IgnoreButtonLeft = 218;
                        break;
                    }
            }
        }
        private static void focusHandle(MessageBoxForm frm, MessageBoxButtons btns, MessageBoxDefaultButton defBtn)
        {
            switch (btns)
            {
                case MessageBoxButtons.Ok:
                    {
                        frm.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        switch (defBtn)
                        {
                            case MessageBoxDefaultButton.Button1:
                                {
                                    frm.OkButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button2:
                                {
                                    frm.CancelButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button3:
                                {
                                    frm.CancelButtonFocus();
                                    break;
                                }
                        }
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        switch (defBtn)
                        {
                            case MessageBoxDefaultButton.Button1:
                                {
                                    frm.YesButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button2:
                                {
                                    frm.NoButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button3:
                                {
                                    frm.NoButtonFocus();
                                    break;
                                }
                        }
                        break;
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        switch (defBtn)
                        {
                            case MessageBoxDefaultButton.Button1:
                                {
                                    frm.RetryButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button2:
                                {
                                    frm.CancelButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button3:
                                {
                                    frm.CancelButtonFocus();
                                    break;
                                }
                        }
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        switch (defBtn)
                        {
                            case MessageBoxDefaultButton.Button1:
                                {
                                    frm.YesButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button2:
                                {
                                    frm.NoButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button3:
                                {
                                    frm.CancelButtonFocus();
                                    break;
                                }
                        }
                        break;
                    }
                case MessageBoxButtons.AbortRetryIgnore:
                    {
                        switch (defBtn)
                        {
                            case MessageBoxDefaultButton.Button1:
                                {
                                    frm.AbortButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button2:
                                {
                                    frm.RetryButtonFocus();
                                    break;
                                }
                            case MessageBoxDefaultButton.Button3:
                                {
                                    frm.IgnoreButtonFocus();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
        private static void optionsHandle((MessageBoxForm frm, MessageBoxOptions optn)
        {
            if ((optn & MessageBoxOptions.RtlReading) == MessageBoxOptions.RtlReading)
            {
                frm.Rtl = System.Windows.Forms.RightToLeft.Yes;
            }
            if ((optn & MessageBoxOptions.RightAlign) == MessageBoxOptions.RightAlign)
            {
                frm.RtlLayout = true;
            }
            if ((optn & MessageBoxOptions.PersianButtons) == MessageBoxOptions.PersianButtons)
            {
                frm.ButtonFarsi();
            }
        }
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
            buttonsHandle(frm:form, btns:buttons);
            focusHandle(frm: form, btns: buttons,defBtn:MessageBoxDefaultButton.Button3);
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            buttonsHandle(frm: form, btns: buttons);
            focusHandle(frm: form, btns: buttons, defBtn: defaultButton);
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxOptions option)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            buttonsHandle(frm: form, btns: buttons);
            focusHandle(frm: form, btns: buttons, defBtn: MessageBoxDefaultButton.Button3);
            optionsHandle(frm: form, optn: option);
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton, MessageBoxOptions option)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = "  "+caption;
            buttonsHandle(frm: form, btns: buttons);
            focusHandle(frm: form, btns: buttons, defBtn: defaultButton);
            optionsHandle(frm: form, optn: option);
            form.ShowDialog();
            return form.MessageBoxResult;
        }
    }
}
