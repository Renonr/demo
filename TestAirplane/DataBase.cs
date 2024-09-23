using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Airplane
{

    class DataBase
    {
        private static string connectionString = @"Data Source=DESKTOP-FRGD4TU\SQLEXPRESS;Initial Catalog=Демо;Integrated Security=false";
        SqlConnection sqlConnection;

        public DataBase(string login, string password)
        {
            string userPassword = ";User ID=" + login + ";Password=" + password;
            connectionString += userPassword;
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public DataBase()
        {
            string userPassword = ";User ID=" + "Admin" + ";Password=" + "Admin";
            connectionString += userPassword;
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        public string getConnectionStatus()
        {
            return sqlConnection.State.ToString();
        }
    }
}
