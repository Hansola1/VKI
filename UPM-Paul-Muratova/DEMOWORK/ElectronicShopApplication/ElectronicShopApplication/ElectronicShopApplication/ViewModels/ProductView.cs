using ElectronicShopApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShopApplication.ViewModels
{
    public class ProductView 
    {
        public int Id { get; set; }
        public int? Cost { get; set; }

        public int? Sale { get; set; }

        public int? Count { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string? Category { get; set; }

        public string? Manufacturer { get; set; }

        public string? Provider { get; set; }


        public string FullImagePath
        {
            get
            {
                if (string.IsNullOrEmpty(Image))
                {
                    return @"D:\CodeData\homeworkFile\UPM-Paul-Muratova\DEMOWORK\ElectronicShopApplication\ElectronicShopApplication\ElectronicShopApplication\Resource\Image\picture.png";
                }

                string pathImage = @"D:\CodeData\homeworkFile\UPM - Paul - Muratova\DEMOWORK\ElectronicShopApplication\ElectronicShopApplication\ElectronicShopApplication\Resource\Image\";
                return Path.Combine(pathImage, Image);
            }
        }

    }
}
