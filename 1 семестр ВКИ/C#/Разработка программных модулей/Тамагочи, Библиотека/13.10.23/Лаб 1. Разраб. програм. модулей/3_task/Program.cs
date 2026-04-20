// 3.Дан массив натуральных чисел, заданных случайным образом из диапазона от 0 до
// 255 и число Х из этого же диапазона. Длина массива равна N.  Если число Х есть в массиве,
// то вычислить сумму элементов массива от первого вхождения этого числа до конца массива, иначе выдать -1.
// Задачу решить для N=10.

using System;

internal class Program
{
    private static void Main(int[] args)
    {
        int[] num = new int[10];
        Random rand = new Random();
        int x = rand.Next(256);
    
        for (int i = 0; i < 10; i++)
        {
            num[i] = rand.Next(256);
        }

        int result = Sum(num, x);
        if (result == -1)
        {
            Console.WriteLine("Number not found in array");
        }
        else
        {
            Console.WriteLine("Sum of elements from first occurrence of {0} to end: {1}", x, result);
        }


    }

    static int Sum(int[]num, int x)
    {
        int sum = 0;
        bool found = false;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == x)
            {
              found = true;
            }

            if (found)
            {
                sum += num[i];
            }
        }

        if (found)
        {
            return sum;
        }
        else
        {
            return -1;
        }

    }
}