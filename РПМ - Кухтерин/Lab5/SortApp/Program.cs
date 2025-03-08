using System.Numerics;

namespace ConsoleApp1
{
    public static class SortAlgorithms<T> where T : INumber<T>
    {
        public static void Swap(ref T value1, ref T value2)
        {
            (value1, value2) = (value2, value1);
        }

        private static int GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            if (s > 1)
            {
                return s;
            }
            return 1;
        }

        public static T[] CombSort(T[] array)
        {
            var currentStep = array.Length - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i].CompareTo(array[i + currentStep]) > 0)
                    {
                        Swap(ref array[i], ref array[i + currentStep]);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            BubbleSort(array);

            return array;
        }

        public static int SelectID(int[] array, int a)
        {
            foreach (int i in array)
            {
                if (i == a)
                {
                    return i;
                }
            }
            return 0;
        }

        public static T[] ShellSort(T[] array)
        {
            for (int gap = array.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    var temp = array[i];
                    var k = i;
                    while (k >= gap && array[k - gap].CompareTo(temp) > 0)
                    {
                        array[k] = array[k - gap];
                        k -= gap;
                    }
                    array[k] = temp;
                }
            }
            return array;
        }

        public static T[] BubbleSort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var swapFlag = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1].CompareTo(array[j]) < 0)
                    {
                        Swap(ref array[j + 1], ref array[j]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
            return array;
        }

        public static string Print(int[] array)
        {
            string result = String.Empty;
            foreach (int i in array)
            {
                result += Convert.ToString(i) + " ";
            }
            return result;
        }
    }
}