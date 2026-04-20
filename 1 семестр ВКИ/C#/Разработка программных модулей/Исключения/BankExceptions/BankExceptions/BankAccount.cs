using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BankExceptions
{
    public class BankAccount
    {
        public int Score { get; set; }

        public BankAccount(int score)
        {
            Score = score;
        }

        public void WithDraw(int money)
        {
            if (Score < money)
            {
                throw new InsufficientFundsException();
            }

            else if (money < 0)
            {
                throw new ArgumentException("Введите значение больше");
            }

            else
            {
                Console.WriteLine($"Cумма {money} снята с вашего счета!");
            }
        }

    }
}
