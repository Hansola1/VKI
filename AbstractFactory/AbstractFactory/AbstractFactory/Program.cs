using AbstractFactory_TaskOne.A;
using AbstractFactory_TaskOne.AbstractFactory;
using AbstractFactory_TaskOne.B;

namespace AbstractFactory_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Random random = new Random();
            int NF = random.Next(0, 2);

            int NA = 5 , NB = 10;
            string S = "AB";

            AbstractFactory f;
            AbstractProductA pa;
            AbstractProductB pb;

            if (NF == 1)
            {
                f = new ConcreteFactory1();
            }
            else
            {
                f = new ConcreteFactory2();

                pa = f.CreateProductA(NA);
                pb = f.CreateProductB(NB);

                foreach (char command in S)
                {
                    if (command == 'A')
                    {
                        pa.A();
                    }
                    else if (command == 'B')
                    {
                        pb.B(pa);
                    }
                }

                Console.WriteLine($"Product A Info: {pa.GetInfo()}");
                Console.WriteLine($"Product B Info: {pb.GetInfo()}");
            }
        }
    }
}