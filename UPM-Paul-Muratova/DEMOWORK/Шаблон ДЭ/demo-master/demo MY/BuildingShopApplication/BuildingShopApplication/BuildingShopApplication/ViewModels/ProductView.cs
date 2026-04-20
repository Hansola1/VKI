using System.IO;

namespace BuildingShopApplication.ViewModels
{
    class ProductView
    {
        public string? Article { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }

        public int? Cost { get; set; }

        public int? MaxDiscount { get; set; }

        public int? StockQuantity { get; set; }

        public string? Image { get; set; }

        public string? Manufacturer { get; set; }

        //public string? Provider { get; set; }


        public string FullImagePath
        {
            get
            {
                if (string.IsNullOrEmpty(Image))
                {
                    return @"D:\CodeData\homeworkFile\UPM-Paul-Muratova\DEMOWORK\BuildingShopApplication\BuildingShopApplication\BuildingShopApplication\Resources\picture.png";
                }

                string pathImage = @"D:\CodeData\homeworkFile\UPM-Paul-Muratova\DEMOWORK\BuildingShopApplication\BuildingShopApplication\BuildingShopApplication\Resources\Image\";
                return Path.Combine(pathImage, Image);
            }
        }

    }
}
