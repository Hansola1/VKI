using System.IO;

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

        public string FullPhotoPath
        {
            get
            {
                if (string.IsNullOrEmpty(Photo))
                    return null;

                string basePath = @"D:\CodeData\homeworkFile\ИПМ - Пауль, Муратова\08.10.25-lab2\ShopShoesApplication\ShopShoesApplication\Resources\Image";
                return Path.Combine(basePath, Photo);
            }
        }
    }


    //// Вычисляемая итоговая цена
    //public decimal FinalPrice => Price * (100 - Discount) / 100;
}