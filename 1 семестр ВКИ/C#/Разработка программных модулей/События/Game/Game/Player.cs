using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public delegate void MethodContainer();
        public event MethodContainer OnFight;

        public int HP = 50;
        public void fight()
        {
            for (int i = HP; i > 0; i--)
            {
                if (i < 20)
                {
                    OnFight();
                    break;
                }
            }
        }
    }
}
