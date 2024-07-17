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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] foods = {"Grain","Bread","Beans","Eggs","Chicken","Milk","Fruit","Vegetables","Pasia","Rice","Fish","Beef"};
            int topPosition = 0;
            foreach(string food in foods )
            {
                CheckBox cb = new CheckBox();
                cb.Text = food;
                cb.Left = 30;
                cb.Top = topPosition;
                this.Controls.Add(cb);
                topPosition += 30;
            }
        }
    }
}
