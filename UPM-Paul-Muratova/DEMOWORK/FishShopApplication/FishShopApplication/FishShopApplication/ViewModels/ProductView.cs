using System.IO;

namespace FishShopApplication.ViewModels
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Artucle { get; set; }
        public string Name { get; set; }
        public string Measurement { get; set; }
        public int Cost { get; set; }
        public string Provider { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public int Sale { get; set; }
        public int QuantityStock { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string FullPhotoPath
        {
            get
            {
                if (string.IsNullOrEmpty(Image))
                    return null;

                string basePath = @"D:\CodeData\homeworkFile\UPM-Paul-Muratova\DEMOWORK\FishShopApplication\FishShopApplication\FishShopApplication\Resource\";
                return Path.Combine(basePath, Image);
            }
        }
    }
}
