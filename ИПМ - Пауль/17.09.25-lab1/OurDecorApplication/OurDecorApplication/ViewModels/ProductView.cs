using OurDecorApplication.Models;

namespace OurDecorApplication.ViewModels
{
    public class ProductView
    {
        public string TypeProduct { get; set; }
        public string NameProduct { get; set; }
        public string Article { get; set; } //И есть ID
        public float MinCostPartner { get; set; }
        public float RollWidth { get; set; }
    }
}
