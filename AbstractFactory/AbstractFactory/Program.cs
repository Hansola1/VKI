using AbstractFactory_TaskOne.Creator;
using AbstractFactory_TaskOne.Product;

namespace AbstractFactory_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void TestClassCreator()
        {
            string line1 = "aaa", line2 = "ddd", line3 = "sss", line4 = "xxx", line5 = "qqq";
            List<string> listLine = new List<string>() { line1, line2, line3, line4, line5 };

            Creator creator1 = new ConcreteCreator1();
            Creator creator2 = new ConcreteCreator2();

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