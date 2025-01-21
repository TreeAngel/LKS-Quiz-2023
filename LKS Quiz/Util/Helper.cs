using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Quiz.Util
{
    public static class Helper
    {
        public static User userSession;

        public static bool IsEmptyOrNo(Control control)
        {
            bool isValid = true;
            isValid = (control.Controls.OfType<TextBox>().Where(x => String.IsNullOrEmpty(x.Text)).Count() == 0 &&
                control.Controls.OfType<RadioButton>().Where(x => x.Checked).Count() == 0);
            return isValid;
        }

        public static void ClearInput(Control control)
        {
            foreach (var item in control.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            foreach (var item in control.Controls.OfType<RadioButton>())
            {
                item.Checked = false;
            }
            foreach (var item in control.Controls.OfType<ComboBox>())
            {
                item.SelectedIndex = -1;
            }
        }

        public static void TextBoxNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
