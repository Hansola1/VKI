namespace FactoryMethod_TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass();
        }


        private static void TestClass()
        {
            string line1 = "aaa", line2 = "ddd", line3 = "sss", line4 = "xxx", line5 = "qqq";
            List<string> listLine = new List<string>() { line1, line2, line3, line4, line5 };

            ConcreteCreator1 creator1 = new ConcreteCreator1();
            ConcreteCreator2 creator2 = new ConcreteCreator2();

            // Применяем метод AnOperation для каждой строки
            foreach (var str in listLine)
            {
                string result1 = creator1.AnOperation(str);
                string result2 = creator2.AnOperation(str);

                Console.WriteLine($"Input: '{str}' | Creator 1 Result: '{result1}' | Creator 2 Result: '{result2}'");
            }
        }

    }
}
