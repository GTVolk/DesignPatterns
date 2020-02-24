namespace DesiginPatterns.Patterns.Creational.FactoryMethod
{
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }
}
