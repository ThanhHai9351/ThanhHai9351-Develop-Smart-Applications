using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2001215742_HoThanhHai_Buoi1.services;

namespace _2001215742_HoThanhHai_Buoi1
{
    
    public partial class TrucXanh : Form
    {
        public TrucXanh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            handleTrucXanhService b = new handleTrucXanhService();
            b.addButton(num, panel1, progressBar1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
