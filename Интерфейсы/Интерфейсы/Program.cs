namespace Интерфейсы 
{
    // Интерфейсы - определение поведения, которое будет реализовано в каком-нибудь классе и
    // как должны будут вести себя наследники(без деталей)

    // Отличие интерфейса от абстракт класс: множественное наследование.
    // Интерфейсы могут наследоваться между собой(один интерфейс может наследовать несколько)

    //Класс реализует интерфейс.

    interface IDataProvider 
    // Все называются с I. Нельзя создать экземпляр, конструктор. 
    // Можно объвить только методы, которые по умолчанию public 
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProccessData(IDataProvider dataProvider);
    }

    // Все методы интерфейса должны быть реализованы в наследнике
    class ConsoleDataProcessor : IDataProcessor // конкретный прооцессор вызывает метод определенный в интерфейсе
    {
        public void ProccessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }

    class FileDateProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }
    class APIDateProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные пришли из API";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor(); // где реализуем
            dataProcessor.ProccessData(new APIDateProvider()); // new FileDateProvider и т.д можем

        }
    }
}