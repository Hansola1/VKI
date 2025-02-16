using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Laboratory.DB
{
    public class DBcontroller
    {
        private static string connectionString = "Server=DBSRV\\ag2024;Database=BorodinaAV_2207d2 NEW;Trusted_Connection=True";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public DBcontroller() { }

        private void Connection()
        {
            try
            {
                sqlConnection.Open();
                Console.WriteLine("Successful connection!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadTables(ListBox tableListBox)
        {
            Connection();
            DataTable schema = sqlConnection.GetSchema("Tables");

            foreach (DataRow row in schema.Rows)
            {
                tableListBox.Items.Add(row["TABLE_NAME"].ToString());
            }

            sqlConnection.Close();
        }

        public void LoadTableData(string tableName, DataGrid dataGrid)
        {
            Connection();

            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", sqlConnection);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;

            sqlConnection.Close();
        }
    }
}
