using FactoryMethod_TaskThree.AmimalsCreators;
using FactoryMethod_TaskThree.Animals;

namespace FactoryMethod_TaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            CatCreator catCreator = new CatCreator();
            ApeCreator apeCreator = new ApeCreator();

            int[] catInds = { 0, 1, 2, 1 };
            string[] catNames = { "Leo", "Tony", "Simba", "Rajah" };
            List<Animal> cats = catCreator.GetZoo(catInds, catNames);
            foreach (var cat in cats)
            {
                Console.WriteLine(cat.GetInfo());
            }

            int[] apeInds = { 0, 2, 1, 0 };
            string[] apeNames = { "Gorgo", "Bobo", "Jojo", "Momo" };
            List<Animal> apes = apeCreator.GetZoo(apeInds, apeNames);
            foreach (var ape in apes)
            {
                Console.WriteLine(ape.GetInfo());
            }
        }

        private static void inputTest()
        {
            Lion myLion = new Lion("Leo");
            string info = myLion.GetInfo();

            Console.WriteLine(info);
        }
    }
}
