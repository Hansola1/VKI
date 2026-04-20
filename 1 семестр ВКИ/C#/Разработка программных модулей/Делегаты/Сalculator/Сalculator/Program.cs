using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator 
{
    delegate double MyDelegate(double x);
    class Program
    {
        // Статический метод, которому аргументом передается ссылка на метод:
        static MyDelegate SumX(double a, double b, double c)
        {
            return x=> a * x + b * x + c * x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a, b, c,");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");

            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            double answer = SumX(a, b, c)(x);
            Console.WriteLine(answer);
        }
    }
}
