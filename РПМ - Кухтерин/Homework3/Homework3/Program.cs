namespace Tasks
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Console.WriteLine("Привет! Напиши размер массива.(больше трех пж)");
            int size = GetValue<int>("size:");

            MultipleOfThree(size); // 1 
            MinimumMaxSwap(size); // 2
            Concatenation(size); // 3

            Console.WriteLine("Введите два факториала. Мы вычислим их сумму.");
            int a = GetValue<int>("a:");
            int b = GetValue<int>("a:");

            SumFactorial(a, b); // 4
            WhileNoStop(); // 5
        }

        private static void Print<T>(T value)
        {
            Console.WriteLine($"{value}");
        }

        private static void ArrPrint<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static T GetValue<T>(string str)
        {
            while (true)
            {
                Console.WriteLine(str);

                try
                {
                    T value = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                    return value;
                }
                catch (Exception)
                {
                    Print("Все плохо");
                }
            }

        }

        private static int[] Arr(int size)
        {
            Random rand = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            return arr;
        }

        private static void MultipleOfThree(int size)
        {
            int[] array = Arr(size);
            int sum = 0, countForMultThree = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    sum += array[i];
                    countForMultThree++;
                }
            }
            //ArrPrint(array);

            if (countForMultThree > 0)
            {
                int arithmetic = sum / size;
                Console.WriteLine($"Среднее арифметическое чисел, кратных трем {arithmetic}");
            }
            else { Console.WriteLine("Мы не нарандомили кратные трем числа!!!"); }
        }

        private static void MinimumMaxSwap(int size)
        {
            int[] array = Arr(size);
            int maxIndex = 0, minIndex = 0;

            //ArrPrint(array);
            for (int i = 0; i < array.Length; i++)
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

            Print($"Введите {size} строчек");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetValue<string>($"Введите элемент массива номер {i}");
            }

            string sum = "";
            for (int i = 2; i < array.Length; i += 3)
            {
                sum += array[i];
            }

            Console.WriteLine($"Результат конкатенации каждого третьего элемента");
            Print(sum);
        }

        private static int Factorial(int a)
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        private static void SumFactorial(int a, int b)
        {
            int factorialA = Factorial(a);
            int factorialB = Factorial(b);

            int sumFactorial = factorialA + factorialB;
            Console.WriteLine($"Cумма факториалов {a}! + {b}! = {sumFactorial}");
        }

        private static void WhileNoStop()
        {
            Console.WriteLine("Пиши сколько хочешь, когда устанешь напиши STOP");

            string a;
            do
            {
                a = GetValue<string>("Введите что-то");
            }
            while (a.ToLower() != "stop");
        }
    }
}
