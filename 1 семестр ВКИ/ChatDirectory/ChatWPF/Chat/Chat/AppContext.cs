using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Emit;
using System.Data.SQLite;

using Npgsql;
//using Npgsql.EntityFrameworkCore;

namespace Chat
{
    public class AppContext : DbContext
    {
        static string connectionString = "Host=localhost;Port=5432;Database=testDB;Username=postgres;Password=root;";
        NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

      /*  public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        } */

        public void DBConnection()
        {
            try
            {
                npgSqlConnection.Open();
                Console.WriteLine("Succesful connection!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // Безвозвратная команда
        public void DBInputCommand(string command)
        {
            DBConnection();
            NpgsqlCommand commandSQL = new NpgsqlCommand(command, npgSqlConnection);
            commandSQL.ExecuteNonQuery();
            npgSqlConnection.Close();
        }

        public void DBClose() { npgSqlConnection.Close(); }
    }
}

