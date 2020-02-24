namespace DesiginPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Класс фабрики B
    /// </summary>
    class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
