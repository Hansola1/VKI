using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayTransformation[] sorts = { SortBubble, SortInsert, SortSelect };
            for (int i = 0; i < sorts.Length; i++)
            {
                int[] arr = { 3, 1, 5, 2 };
                sorts[i](arr);
                Print(arr);
            }
        }


        delegate void ArrayTransformation(int[] a);
        static void SortBubble(int[] a)
        {
            Console.WriteLine("Выполнение пузырьковой сортировки");

            int n = a.Length;
            int left = 0, right = n - 1;

            bool x = true;
            while (x)
            {
                x = false;
                for (int i = left; i < right; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        //std::swap(a[i], a[i + 1]);
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                        x = true;
                    }
                }
                right--;

                if (x)
                {
                    x = false;
                    for (int i = right; i > left; i--)
                    {
                        if (a[i] < a[i - 1])
                        {
                            //std::swap(a[i], a[i - 1]);
                            (a[i], a[i - 1]) = (a[i - 1], a[i]);
                            x = true;
                        }
                    }
                    left++;
                }
            }
        }

        static void SortInsert(int[] a)
        {
            Console.WriteLine("Выполнение сортировки вставками");

            int x; int n = 4;
            for (int i = 1; i < n; i++)
            {
                x = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > x)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = x;
            } 
        }

        static void SortSelect(int[] a)
        {
            Console.WriteLine("Выполнение сортировки выбором");

            int x_min, i, j;
            int n = 4;
            for (i = 0; i < n - 1; i++)
            {
                x_min = i;
                for (j = i + 1; j < n; j++)
                {
                    if (a[j] < a[x_min])
                    {
                        x_min = j;
                    }
                }

                if (a[i] != a[x_min])
                {
                    // swap(a[i], a[x_min]);
                    (a[i], a[x_min]) = (a[x_min], a[i]);
                }
            }
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
