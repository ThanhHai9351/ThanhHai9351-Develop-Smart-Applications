using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215742_HoThanhHai_Buoi4
{
    public class QL_NguoiDung
    {
        public QL_NguoiDung()
        {

        }

        public int Check_Config()
        {
            if (Properties.Settings.Default.cnn == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.cnn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }

        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'",
            Properties.Settings.Default.cnn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginResult.Disabled;// Không hoạt động
            }
            return LoginResult.Success;// Đăng nhập thành công
        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            Properties.Settings.Default.cnn = "Data Source=" +
           pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass
            + "";
            Properties.Settings.Default.Save();
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connection = new
                  SqlConnection("Data Source="+pServer+";Initial Catalog=master;User ID="+pUser+";Password="+pPass);
                    string query = "select name from sys.Databases";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    connection.Open();
                    da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching database names: " + ex.Message);
            }
            return dt;
        }

    }
}
