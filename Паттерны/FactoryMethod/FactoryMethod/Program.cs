using FactoryMethod_TaskOne.Creator;
using FactoryMethod_TaskOne.Product;
using Microsoft.VisualBasic;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestClassProduct();
            TestClassCreator();
        }

        private static void TestClassProduct()
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            ConcreteProduct1 product1 = new ConcreteProduct1(line1);
            ConcreteProduct2 product2 = new ConcreteProduct2(line2);

            Console.WriteLine("ДО Transform:");
            Console.WriteLine("Product 1 Info: " + product1.GetInfo());
            Console.WriteLine("Product 2 Info: " + product2.GetInfo());

            product1.Transform();
            product2.Transform();

            Console.WriteLine("\nПосле Transform:"); //+ доп пробелы, звездочки
            Console.WriteLine("Product 1 Info: " + product1.GetInfo());
            Console.WriteLine("Product 2 Info: " + product2.GetInfo());
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
