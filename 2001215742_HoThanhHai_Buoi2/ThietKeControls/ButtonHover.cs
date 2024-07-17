using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ThietKeControls
{
    public class ButtonHover:Button
    {
        public ButtonHover()
        {
            this.MouseEnter += ButtonHover_MouseEnter;
            this.MouseLeave += ButtonHover_MouseLeave;
            this.BackColor = Color.Blue;
        }

        void ButtonHover_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        void ButtonHover_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
