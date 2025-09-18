namespace OurDecorApplication.Models
{
    public enum ProductType
    {
        Unknown = 0,
        WallPaper = 1,
        FloorCovering = 2,
        CeilingPanel = 3,
        Furniture = 4
    }

    public class Product
    {
        public ProductType TypeProduct { get; set; }
        public string NameProduct { get; set; }
        public string Article { get; set; } //И есть ID
        public float MinCostPartner { get; set; }
        public float RollWidth { get; set; }
    }
}