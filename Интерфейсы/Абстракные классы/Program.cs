namespace Абстракные_классы
{
    public abstract class Weapon
    { 
        public abstract int Damage {  get; }

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

        public void CheckInfo(Weapon weapon) //(IHasInfo hasInfo)
        {
            weapon.ShowInfo();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
