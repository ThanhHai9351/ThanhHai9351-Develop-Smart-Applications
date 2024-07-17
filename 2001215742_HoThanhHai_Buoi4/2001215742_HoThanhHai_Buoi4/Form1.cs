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
    public partial class Form1 : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public Form1()
        {
            InitializeComponent();
            this.btnLogin.Click += btnLogin_Click;
        }

    

        void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                //ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                //ProcessConfig();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    public void ProcessLogin()
{
        LoginResult result;
        result = CauHinh.Check_User(txtUsername.Text, txtPassword.Text); //Check_User viết trong Class QL_NguoiDung
        // Wrong username or pass
        if (result == LoginResult.Invalid)
        {
        MessageBox.Show("Sai " + lblUsername.Text + " Hoặc " +
        lblPassword.Text);
        return;
        }
        // Account had been disabled
        else if (result == LoginResult.Disabled)
        {
        MessageBox.Show("Tài khoản bị khóa");
        return;
        }
        if (Program.frmMain == null || Program.frmMain.IsDisposed)
        {
        Program.frmMain = new mainForm();
        }
        this.Visible = false;
        Program.frmMain.Show();
        }
    }
}
