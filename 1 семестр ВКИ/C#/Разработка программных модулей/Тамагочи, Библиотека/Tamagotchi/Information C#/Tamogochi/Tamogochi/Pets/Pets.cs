using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tamogochi.Pets
{
    internal class Pets
    {
        public string NamePet { get; set; }
        public int Hungry { get; set; }

        public int Happy { get; set; }


        public Pets(string namePet, int hungry, int happy)
        {
            NamePet = namePet;
            Hungry = hungry;
            Happy = happy;
        }

    }
}
