using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    {
        public delegate void MethodContainer();
        public event MethodContainer OnBack;
        public event MethodContainer OnFront;
        public event MethodContainer OnLeft;
        public event MethodContainer OnRight;

        public void MoveBack()
        {
            OnBack();
        }
        public void MoveFront()
        {
            OnFront();
        }
        public void MoveLeft()
        {
            OnLeft();
        }
        public void MoveRight()
        {
            OnRight();
        }
    }
}
