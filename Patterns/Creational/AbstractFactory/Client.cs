namespace DesiginPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Класс клиента, в котором происходит взаимодействие между объектами
    /// </summary>
    class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        // Конструктор
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
