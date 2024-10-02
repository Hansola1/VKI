using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите 2 числа!");
            int numberOne = GetValue("numberOne: ");
            int numberTwo = GetValue("numberTwo ");

            int sum = GetSum(numberOne, numberTwo);
            Console.WriteLine($"Результат суммы: {sum}");

            int multiplication = GetMultiplication(sum);
            Console.WriteLine($"Результат произведения суммы на число: {multiplication}");
        }

        private static int GetSum(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;

            return result;
        }

        private static int GetMultiplication(int sum)
        {
            Console.WriteLine($"Введит число на которые умножаем сумму!");
            int a = GetValue("a: ");
            int result = sum * a;

            return result;
        }

        private static int GetValue(string str) 
        {
            Console.WriteLine(str);
            int n = Convert.ToInt32(Console.ReadLine());

            return n;
        }
    }
}
