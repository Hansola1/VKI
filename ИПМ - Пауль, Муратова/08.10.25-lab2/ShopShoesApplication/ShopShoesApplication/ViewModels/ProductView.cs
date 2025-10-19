namespace ShopShoesApplication.ViewModels
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Arcticle { get; set; }
        public string Name { get; set; }
        public string MeasurementUnit { get; set; }
        public int Price { get; set; }

        // Отображаем НАЗВАНИЯ, а не ID
        public string Provider { get; set; }       
        public string Manufacturer { get; set; }  
        public string Category { get; set; }       

        public int Discount { get; set; } 
        public int Count { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}