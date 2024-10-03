namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            int resultOne = Sum(1, 1);
            Print(resultOne);

            string resultTwo = Sum("1", "1");
            Print(resultTwo);

            int resultFour = Sum(1, "2");
            Print(resultFour);

            int[] arr = Arr();
            ArrPrint(arr);
            int resultThree = Sum(arr);
            Print(resultThree);
        }

        private static void Print<T>(T value)
        {
            Console.WriteLine($"Результат {value}");
        }


        private static void ArrPrint <T> (T[] arr)
        {
            for(int i = 0; i < arr.Length; i++ )
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static int[] Arr()
        {
            Random rand = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            return arr;
        }

        private static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }

        private static string Sum(string a, string b)
        {
            string c = a + b;
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
            bool s = int.TryParse(b, out int result);
            int answer;

            if (s)
            {
                answer = a + result;
            }
            else
            {
                Console.WriteLine("У вас ошибка!!!");
                answer = 0;
            }
            return answer;
        }
    }
}
