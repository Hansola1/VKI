using System;
using static BankExceptions.BankAccount;
using static BankExceptions.InsufficientFundsException;


namespace BankExceptions
{
    class Program
    { 
        public static void Main(string[] args)
        {
            int score = Convert.ToInt32(Console.ReadLine());
            BankAccount bank = new BankAccount(score);

            try 
            {
                int money = Convert.ToInt32(Console.ReadLine());
                bank.WithDraw(money);
                Console.WriteLine("С вашего счета снято: " + money);
            }

            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}






