namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Привет! Напиши размер массива.(больше трех пж)");
            int size = Convert.ToInt32(Console.ReadLine());

            MultipleOfThree(size, random); // 1 
            MinimumMaxSwap(size, random); // 2
            Concatenation(size); // 3

            Console.WriteLine("Введите два факториала. Мы вычислим их сумму.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            SumFactorial(a, b); // 4

            Console.WriteLine("Пиши сколько хочешь, когда устанешь напиши STOP");
            WhileNoStop();

        }

        private static void MultipleOfThree(int size, Random random)
        {
            int[] array = new int[size];
            int sum = 0, countForMultThree = 0;

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next();
                if (array[i] % 3 == 0)
                {
                    sum += array[i];
                    countForMultThree++;
                }
            }

            if (countForMultThree > 0)
            {
                int arithmetic = sum / size;
                Console.WriteLine($"Среднее арифметическое чисел, кратных трем {arithmetic}");
            }
            else { Console.WriteLine("Мы не нарандомили кратные трем числа!!!"); }
        }

        private static void MinimumMaxSwap(int size, Random random)
        {
            int[] array = new int[size];
            int maxIndex = 0, minIndex = 0;

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next();
            }

            for (int i = 0; i < size; i++)
            {
                if (array[i] == array.Max())
                {
                    maxIndex = i;
                }
                if (array[i] == array.Min())
                {
                    minIndex = i;
                }
            }

            int temp = minIndex;
            minIndex = maxIndex;
            maxIndex = temp;
            //(minIndex, maxIndex) = (maxIndex, minIndex); а ещё можно свапать так :)

            array[3] = 0;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void Concatenation(int size)
        {
            string[] array = new string[size];

            Console.WriteLine($"Введите {size} строчек");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }

            string sum = "";
            for(int i = 2; i < size; i += 3)
            {
                sum += array[i];
            }

            Console.WriteLine($"Результат конкатенации каждого третьего элемента: {sum}");
        }

        private static void SumFactorial(int a, int b)
        {
            int factorialA = 1, factorialB = 1;

            for(int i = 1; i <= a; i++)
            {
                factorialA = factorialA * i;
            }

            for (int i = 1; i <= b; i++)
            {
                factorialB = factorialB * i;
            }
            int sumFactorial = factorialA + factorialB;
            Console.WriteLine($"Cумма факториалов {a}! + {b}! = {sumFactorial}");
        }

        private static void WhileNoStop()
        {
            string a;
            do
            {
                a = Console.ReadLine();
            }
            while (a.ToLower() != "stop");
        }
    }
}

