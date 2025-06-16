using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryApp.DAL
{
    public class DbHelper : IDisposable
    {
        protected string connectionString = "Server=Ase;Database=MyLibraryDB;Trusted_Connection=True;";
        // "Server=YOUR_SERVER_NAME;Database=MyLibraryDB;User ID=YourUser;Password=YourPassword";

        protected SqlConnection connection;

        public DbHelper()
        {
            connection = new SqlConnection(connectionString);
        }

        protected void OpenConnection()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("حدث خطأ في الاتصال " + ex.Message, "خطأ في قاعدة البيانات",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }

        protected void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
                connection = null;
            }
        }

    }
}