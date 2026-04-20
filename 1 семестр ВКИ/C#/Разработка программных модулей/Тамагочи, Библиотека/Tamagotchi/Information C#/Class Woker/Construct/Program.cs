using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct
{
    public class MainClass
    {
        public static void Main()
        {
            var myWatch = new Watch("Casio", "electronic", 15.99);
            myWatch.Print();
        }
    }
    class Watch
    {
        public string name;
        public string typel;
        public double cost;

        public Watch(string Name, string Typel, double Cost)
        {
            name = Name;
            typel = Typel;
            cost = Cost;
        }

        public void Print()
        { 
            Console.WriteLine($"Часы {name}, тип: {typel}, цена: {cost}");  
        }
    }

}
