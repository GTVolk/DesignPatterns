namespace DesiginPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Класс абстрактной фабрики
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
