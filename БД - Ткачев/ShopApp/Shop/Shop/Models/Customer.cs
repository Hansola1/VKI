using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string pasword { get; set; } = string.Empty;

        //public ICollection<Order> Orders { get; set; }
    }
}

