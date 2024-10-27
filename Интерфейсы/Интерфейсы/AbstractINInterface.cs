using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейсы
{
    public class AbstractINInterface
    {

    }

    interface IHasInfo
    {
        void ShowInfo();
    }

    interface IWeapon
    {
        public abstract int Damage { get; }

        public abstract void Fire();
    }

    public abstract class Weapon : IHasInfo, IWeapon 
    {
        public abstract int Damage { get; }

        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage:{Damage}");
        }
    }

    class Gun : Weapon // обязательно реализовать все функции из предка
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("ПиуПиу!");
        }

    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(IHasInfo hasInfo) // от интерфейса
        {
            hasInfo.ShowInfo();
        }
    }
}
