using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001215742_HoThanhHai_Buoi4
{
    public partial class FormCauHinh : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public FormCauHinh()
        {
            InitializeComponent();
            this.cboServer.DropDown += cboServer_DropDown;
            this.cboDatabase.DropDown += cboDatabase_DropDown;
            this.btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cboServer.Text, txtUsername.Text, txtPassword.Text,
cboDatabase.Text);
            this.Close();
        }

       

        void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource =CauHinh.GetDBName(cboServer.Text.Trim(),txtUsername.Text.Trim(),txtPassword.Text.Trim());
            cboDatabase.DisplayMember = "name";
        }

        void cboServer_DropDown(object sender, EventArgs e)
        {
            cboServer.DataSource = CauHinh.GetServerName();
            cboServer.DisplayMember = "ServerName";
        }

        private void FormCauHinh_Load(object sender, EventArgs e)
        {

        }
    }
}
