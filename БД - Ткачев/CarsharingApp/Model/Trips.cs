using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsharingApp.Model
{
    public class Trips
    {
        public int TransportId { get; set; }
        public int UserId { get; set; }
        public string Startdt { get; set; }
        public int Duration { get; set; }
        public double CostValue { get; set; }
        public bool IsPaid { get; set; }
    }

}