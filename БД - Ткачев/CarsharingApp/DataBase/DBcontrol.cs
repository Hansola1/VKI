﻿using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace data.DataBase
{
    public class DBControl
    {
        protected static string connectionString = "Server=DANICHLAPTOP;Database=Carsharing;Trusted_Connection=True;TrustServerCertificate=True;";
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