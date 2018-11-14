namespace Nvd.Windows.Forms
{
    public static class MessageBox
    {
        public static DialogResult Show(string text)
        {
            //return System.Windows.Forms.MessageBox.Show(text:messageText);

            MessageBoxForm form = new MessageBoxForm();
            form.MessageText = text;
            form.ShowDialog();
            return DialogResult.Ok;
        }
    }
}
