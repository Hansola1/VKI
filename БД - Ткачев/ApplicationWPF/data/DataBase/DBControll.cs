using System.Data;
using System.Data.SqlClient;
using System.Windows;
using data.Model;
using data.Views.Pages;

namespace data.DataBase
{
    public class DBControll
    {
        //private static string connectionString = "Server=DBSRV\\ag2024;Database=BorodinaAV_2207d2 NEW;Trusted_Connection=True";
        protected static string connectionString = "Server=DANICHLAPTOP;Database=BorodinaAV_2207d2;Trusted_Connection=True";
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
