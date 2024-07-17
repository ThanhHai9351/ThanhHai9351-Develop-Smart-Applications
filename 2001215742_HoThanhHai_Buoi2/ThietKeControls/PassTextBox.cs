using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThietKeControls
{
    public class PassTextBox : TextBox
    {
        private ErrorProvider errorProvider;
        private bool isInputValid = false;

        public PassTextBox()
        {
            errorProvider = new ErrorProvider();
            this.TextChanged += PassTextBox_TextChanged;
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = this.Text;

            if (ContainsSpecialCharacters(input) && input.Length >= 6)
            {
                errorProvider.Clear();
                isInputValid = true;
            }
            else
            {
                errorProvider.SetError(this, "Mật khẩu phải chứa ít nhất một ký tự đặc biệt và có ít nhất 6 ký tự.");
                isInputValid = false;
            }
        }

        private bool ContainsSpecialCharacters(string input)
        {
            Regex regex = new Regex("[~!@#$%^&*()_+={}\\[\\]:;<>,.?/\\\"]");
            return regex.IsMatch(input);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public bool IsValidInput()
        {
            return isInputValid;
        }
    }
}
