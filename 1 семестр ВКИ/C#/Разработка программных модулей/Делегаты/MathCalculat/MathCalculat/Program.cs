using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            XMathFunct[] sorts = { Sin, Cos, Log, Exp, Round };
            for (int i = 0; i < sorts.Length; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                sorts[i](x);
            }
        }


        delegate void XMathFunct(double x);
        static void Sin(double x)
        {
            Console.WriteLine("Синус функции:");
            Console.WriteLine(Math.Sin(x));

        }
        static void Cos(double x)
        {
            Console.WriteLine("Косинус функции:");
            Console.WriteLine(Math.Cos(x));
        }

        static void Log(double x)
        {
            Console.WriteLine("Выполнение сортировки вставками");
            Console.WriteLine(Math.Log(x));
        }

        static void Exp(double x)
        {
            Console.WriteLine("e:");
            Console.WriteLine(Math.Exp(x));
        }

        static void Round(double x)
        {
            Console.WriteLine("Округление:");
            Console.WriteLine(Math.Round(x));
        }
    }
}
