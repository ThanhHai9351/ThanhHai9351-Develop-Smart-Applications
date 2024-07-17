using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace _2001215742_HoThanhHai_Buoi3
{
    public partial class Form1 : Form
    {
        SqlClass sql = new SqlClass();
        string connectionString = "Server=A109PC49;Database=Buoi3;Trusted_Connection=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                sql.CreateConnection(connectionString);

                if (sql.TestConnection())
                {
                    MessageBox.Show("Connected successfully!");
                }
                else
                {
                    MessageBox.Show("Connection failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlClass sql = new SqlClass();
            try
            {
                sql.CreateConnection(connectionString);
                DataTable table = sql.ExecuteQuery("SELECT * FROM Student");
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql.CreateConnection(connectionString);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string query = "DELETE Student WHERE ID =" + rowIndex.ToString();

                if (sql.Delete(query))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa");
            }
        }

    }
}
