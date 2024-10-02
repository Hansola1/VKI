using System;

namespace Homework2
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int resultOne = Sum(1, 1);
            Console.WriteLine(resultOne);

            int resultTwo = Sum("1", "1");
            Console.WriteLine(resultTwo);

            int resultFour = Sum(1, "1");
            Console.WriteLine(resultFour);

            Random rand = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }

            int resultThree = Sum(arr);
            Console.WriteLine(resultThree);
        }

        private static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }

        private static int Sum(string a, string b)
        {
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            return c;
        }

        private static int Sum(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count += arr[i];
            }

            return count;
        }

        private static int Sum(int a, string b)
        {
            int c = a + Convert.ToInt32(b);

            if (c == 0)
            {
                Console.WriteLine("У вас ошибка!!!");
                return 0;
            }
            else
            {
                return c;
            }
        }
    }
}
