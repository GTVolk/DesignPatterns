using System;

namespace DesiginPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Первый класс продукта типа В
    /// </summary>
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// Второй класс продукта типа В
    /// </summary>
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
