using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BankExceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Недостаточно средств на счете")
        {

        }
    }
}
