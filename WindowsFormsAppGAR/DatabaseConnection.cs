using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsAppGAR
{
    class DatabaseConnection
    {
        SqlConnection SqlConnection = new SqlConnection(@"Server = DESKTOP-F4DDTQQ\SQLEXPRESS; Database=Alpha_FIAS;Trusted_Connection=True;");

        public void OpenConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
