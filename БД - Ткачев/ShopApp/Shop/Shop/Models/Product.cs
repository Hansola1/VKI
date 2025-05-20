using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public double price { get; set; }

        //public ICollection<Order> Orders { get; set; }
    }
}
