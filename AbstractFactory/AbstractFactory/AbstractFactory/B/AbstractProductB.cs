﻿using AbstractFactory_TaskOne.A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.B
{
    public abstract class AbstractProductB
    {
        public abstract AbstractProductB CreateProductB(string info);
    }
}