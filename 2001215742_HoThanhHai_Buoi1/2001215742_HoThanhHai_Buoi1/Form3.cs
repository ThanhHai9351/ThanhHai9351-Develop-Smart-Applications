using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001215742_HoThanhHai_Buoi1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls )
            {
                if(item.GetType()==typeof(TextBox))
                {
                    item.Text = "";
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
