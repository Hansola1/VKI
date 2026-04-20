using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washer
{
    public class Garage
    {
        Car car = new Car();

        public List<Car> car;

        public delegate void CarDelegate(Car car);

    }
}
