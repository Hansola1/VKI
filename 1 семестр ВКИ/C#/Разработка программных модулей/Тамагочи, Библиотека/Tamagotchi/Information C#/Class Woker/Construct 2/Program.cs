using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Construct_2
{
    public class MainClass
    {
        public static void Main()
        {
            var barrel = new Barrel();
            barrel.material = "oak";
            barrel.volume = 200;
            barrel.ToChange(100);
            barrel.ToChange("beech");
            Console.WriteLine($"{barrel.material}, {barrel.volume}");
        }
    }
    class Barrel
    {
        public int volume;
        public string material;

        public void ToChange(int newVolume)
        {
            this.volume = newVolume; // ссылка
        }

        public void ToChange(string newMaterial)
        {
            this.material = newMaterial;
        }
    }
}


