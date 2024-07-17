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
    public partial class Bai1_TuLam : Form
    {
        bool x;
        public Bai1_TuLam()
        {
            InitializeComponent();
        }

        private void Bai1_TuLam_Load(object sender, EventArgs e)
        {
            addMatrixCaro(10,10);
        }

        public void addMatrixCaro(int x,int y)
        {
            handleEventButtonB1 handle = new handleEventButtonB1();
            handle.addButton(x, y, this);
        }

       
    }
}
