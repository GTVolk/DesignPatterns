using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPatterns.Patterns.Creational.FactoryMethod
{
    class ConcreteProductA : Product
    {
        public override string GetProductType() { return "ConcreteProductA"; }
    }

    class ConcreteProductB : Product
    {
        public override string GetProductType() { return "ConcreteProductB"; }
    }
}
