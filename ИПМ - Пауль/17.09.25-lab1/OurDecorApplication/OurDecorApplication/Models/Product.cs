using System.ComponentModel.DataAnnotations;

namespace OurDecorApplication.Models
{
    //public enum ProductType
    //{
    //    Unknown = 0,
    //    WallPaper = 1,
    //    FloorCovering = 2,
    //    CeilingPanel = 3,
    //    Furniture = 4
    //}

    public class Product
    {
        public string TypeProductId { get; set; }
        public string TypeProduct { get; set; }
        public string NameProduct { get; set; }
        [Key]
        public double Article { get; set; } //И есть ID
        public double MinCostPartner { get; set; }
        public double RollWidth { get; set; }
    }
}