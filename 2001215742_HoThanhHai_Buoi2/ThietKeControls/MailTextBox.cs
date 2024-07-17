using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class MailTextBox:TextBox
    {
        ErrorProvider errorProvider;
        public MailTextBox()
        {
            this.KeyUp += MailTextBox_KeyUp;
            this.errorProvider = new ErrorProvider();
        }

        void MailTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string currentText = ((TextBox)sender).Text.Trim();

            if (currentText.Contains("@") && currentText.EndsWith(".com"))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError((TextBox)sender, "Email không hợp lệ. Phải có ký tự @ và kết thúc bằng .com");
            }
        }
    }
}
