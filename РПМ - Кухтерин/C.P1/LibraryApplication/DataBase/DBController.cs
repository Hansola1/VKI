using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace LibraryApplication.DataBase
{
    public class DBController
    {
        protected static string connectionString = "Server=DANICHLAPTOP;Database=Library;Trusted_Connection=True;TrustServerCertificate=True;";
        protected SqlConnection sqlConnection = new(connectionString);

        protected void Connection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}