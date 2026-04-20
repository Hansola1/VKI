using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Npgsql;
namespace Chat
{
    [Table("User")]
    class User
    {        
        //   public int ID { get; set; }
        public string _login;
        public string _password;

        [Key]
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }
}
