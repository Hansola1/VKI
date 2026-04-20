using System;
using Tamagotchi.Animals;
using Tamagotchi.foodPets;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { NikName = "Вася", TypeName = "Кот", Hunger = 10 };
            Dog dog = new Dog { NikName = "Бобик", TypeName = "Собака", Hunger = 10 };
            Horse horse = new Horse { NikName = "Маргоша", TypeName = "Лошадь", Hunger = 20 };

            while (true)
            {
                Console.WriteLine("Выберите питомца:");
                Console.WriteLine("1. Кот");
                Console.WriteLine("2. Собака");
                Console.WriteLine("3. Лошадь");
                Console.WriteLine("4. Выйти");

                string animalChoice = Console.ReadLine();

                switch (animalChoice)
                {
                    case "1":
                        PerformActions(cat);
                        break;
                    case "2":
                        PerformActions(dog);
                        break;
                    case "3":
                        PerformActions(horse);
                        break;
                    case "4":
                        Console.WriteLine("Прощайте");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор...");
                        break;
                }
            }
        }
        static void PerformActions(Pets pet)
        {
            Console.WriteLine($"Вы выбрали {pet.NikName} это {pet.TypeName}.");

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Голос");
                Console.WriteLine("2. Поиграть");
                Console.WriteLine("3. Бегать");
                Console.WriteLine("4. Покормить");
                Console.WriteLine("5. Выбору питомца");

                string actionChoice = Console.ReadLine();

                switch (actionChoice)
                {
                    case "1":
                        pet.Say();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Run();
                        break;
                    case "4":
                        FeedPet(pet);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Попробуйте снова!");
                        break;
                }

                if (pet.Hunger < 0)
                {
                    Console.WriteLine($"Вы не покормили {pet.NikName} вовремя, и он умер! ;(");
                    Environment.Exit(0);

                    Console.WriteLine($"{pet.NikName} Уровень голода {pet.Hunger}");
                }
            }
        }


        static void FeedPet(Pets pet)
        {
            Console.WriteLine("Выберите корм");
            Console.WriteLine("1. Яблоко");
            Console.WriteLine("2. Апельсин");
            Console.WriteLine("3. Сухой корм");

            string foodChoice = Console.ReadLine();

            Food selectedFood = null;
            switch (foodChoice)
            {
                case "1":
                    selectedFood = new Food { type = "Яблоко", energy = 10 };
                    break;
                case "2":
                    selectedFood = new Food { type = "Трава", energy = 5 };
                    break;
                case "3":
                    selectedFood = new Food { type = "Сухой корм", energy = 15 };
                    break;
                default:
                    Console.WriteLine("Неверный выбор...");
                    return;
            }

            pet.Eat(selectedFood);
        }


    }
}