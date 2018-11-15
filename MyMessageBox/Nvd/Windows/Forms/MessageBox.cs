﻿namespace Nvd.Windows.Forms
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
            form.CancelButtonVisible = false;
            form.YesButtonVisible = false;
            form.NoButtonVisible = false;
            form.OkButtonFocus();
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption)
        {
            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.Caption = caption;
            form.OkButtonLeft = 142;
            form.CancelButtonVisible = false;
            form.YesButtonVisible = false;
            form.NoButtonVisible = false;
            form.OkButtonFocus();
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
                        form.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.YesButtonVisible = false;
                        form.NoButtonVisible = false;
                        form.CancelButtonFocus();
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.OkButtonVisible = false;
                        form.CancelButtonVisible = false;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        form.NoButtonFocus();
                        break;
                    }
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defButton)
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
                        form.OkButtonFocus();
                        break;
                    }
                case MessageBoxButtons.OkCancel:
                    {
                        form.YesButtonVisible = false;
                        form.NoButtonVisible = false;
                        if (defButton == MessageBoxDefaultButton.Button1) { form.OkButtonFocus(); } else { form.CancelButtonFocus(); }
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        form.OkButtonVisible = false;
                        form.CancelButtonVisible = false;
                        form.NoButtonLeft = 272;
                        form.YesButtonLeft = 196;
                        if (defButton == MessageBoxDefaultButton.Button1) { form.YesButtonFocus(); } else { form.NoButtonFocus(); }
                        break;
                    }
            }
            form.ShowDialog();
            return form.MessageBoxResult;
        }
    }
}
