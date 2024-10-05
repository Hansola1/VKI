using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskOne.Product
{
    public abstract class Product
    // Абстрактный класс — это класс, который не может быть непосредственно создан (new) и служит как основа для других классов.
    // Он позволяет определить общий интерфейс и поведение для классов-наследников, но сам не реализует все методы. 
    {
        public abstract string GetInfo();
        public abstract void Transform();

    }
}
