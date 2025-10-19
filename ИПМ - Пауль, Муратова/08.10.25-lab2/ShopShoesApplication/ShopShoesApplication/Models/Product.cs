namespace ShopShoesApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Arcticle { get; set; } //очепятка, только смирюсь 

        public string Name { get; set; }
        public string MeasurementUnit { get; set; }

        public int Price { get; set; }

        public int ProviderId { get; set; } 

        public int ManufacturerId { get; set; }

        public int CategoryId { get; set; }

        public int Discount { get; set; }

        public int Count { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }


        public Provider Provider { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public Category Category { get; set; }
    }
}
