using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureExceptions
{
    public class InvalidTemperatureException : Exception
    {
        public InvalidTemperatureException(string mess) : base(mess)
        //передать InsufficientFundsException в базовый класса (Exception)  
        {

        }
    }
}
