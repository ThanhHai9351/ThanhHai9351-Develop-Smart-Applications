using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    class UpperTextBox:TextBox
    {
        public UpperTextBox()
        {
            this.KeyPress += UpperTextBox_KeyPress;
        }

        void UpperTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
