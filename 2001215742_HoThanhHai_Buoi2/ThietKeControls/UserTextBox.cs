using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThietKeControls
{
    public class UserTextBox:TextBox
    {
        ErrorProvider errorprovider;
        public UserTextBox()
        {
            this.errorprovider = new ErrorProvider();
            this.KeyPress += UserTextBox_KeyPress;
        }
        private bool ContainsSpecialCharacters(string input)
        {
            Regex regex = new Regex("[~!@#$%^&*()_+={}\\[\\]:;<>,.?/\\\"]");
            return regex.IsMatch(input);
        }
        void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((TextBox)sender).Text.Trim();
            if (ContainsSpecialCharacters(text))
            {
                errorprovider.SetError(this, "Không được nhập ký tự đặc biệt.");
            }
            else
            {
                errorprovider.Clear();
            }
        }
    }
}
