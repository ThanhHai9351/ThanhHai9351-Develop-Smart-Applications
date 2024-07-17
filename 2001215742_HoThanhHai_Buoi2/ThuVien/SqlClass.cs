using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ThuVien
{
    public class SqlClass
    {
        SqlConnection connection;
        public SqlClass()
        {
            this.connection = null;
        }
        public void CreateConnection(string pConnectionString)
        {
            connection = new SqlConnection(pConnectionString);
            connection.Open();
        }

        public bool TestConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public DataTable ExecuteQuery(string pQuery)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(pQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            return dataTable;
        }


        public bool Insert(string pQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true; 
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting data: " + ex.Message);
                return false;
            }
        }

        public bool Update(string pQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting data: " + ex.Message);
                return false;
            }
        }

        public bool Delete(string pQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, connection);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting data: " + ex.Message);
                return false;
            }
        }

    }
}
