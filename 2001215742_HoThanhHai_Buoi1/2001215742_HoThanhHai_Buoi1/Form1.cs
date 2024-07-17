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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Name = "b1";
            b.Text = "Bai 1 ne";
            b.Left = 30;
            b.Top = 30;
            this.Controls.Add(b);
            b.Click += new System.EventHandler(bt_Click);

        }

        private void bt_Click(object sender,EventArgs e)
        {
            MessageBox.Show("OKEE");
        }
    }
}
