using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washer
{
    public class Car
    {
        public string Color { get; set; }

        public Car(string color) 
        { 
            Color = color;
        }

        public static Car FromColor(string color)
        {
            return new Car(color);
        }
    }
}
