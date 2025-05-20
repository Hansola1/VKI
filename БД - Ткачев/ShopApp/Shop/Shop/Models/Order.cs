using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public int fcustomer_id { get; set; } 
        public int fproduct_id { get; set; }   
        public DateTime? order_date { get; set; }

        [ForeignKey("fcustomer_id")]
        public Customer Customer { get; set; }

        [ForeignKey("fproduct_id")]
        public Product Product { get; set; }
    }
}
