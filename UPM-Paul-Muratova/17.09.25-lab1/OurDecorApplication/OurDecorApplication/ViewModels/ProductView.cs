using OurDecorApplication.Models;

namespace OurDecorApplication.ViewModels
{
    public class ProductView
    {
        public string TypeProduct { get; set; }
        public string NameProduct { get; set; }
        public double Article { get; set; } //И есть ID
        public double MinCostPartner { get; set; }
        public double RollWidth { get; set; }
    }
}
