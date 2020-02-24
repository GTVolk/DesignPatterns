namespace DesiginPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Класс фабрики A
    /// </summary>
    class ConcreteFactoryA : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
