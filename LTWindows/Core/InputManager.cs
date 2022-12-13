namespace LTWindows.Core
{
    internal class InputManager
    {
        public static void txtb_KeyPress(ref object sender, ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one dot
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
