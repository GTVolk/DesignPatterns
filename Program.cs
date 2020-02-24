using System;

namespace DesiginPatterns
{
    class Program
    {
        #region Creational pattern tests

        static void TestAbstractFactory()
        {
            // Вызов абстрактной фабрики A
            Patterns.Creational.AbstractFactory.AbstractFactory factoryA = new Patterns.Creational.AbstractFactory.ConcreteFactoryA();
            Patterns.Creational.AbstractFactory.Client clientA = new Patterns.Creational.AbstractFactory.Client(factoryA);
            clientA.Run();

            // Вызов абстрактной фабрики B
            Patterns.Creational.AbstractFactory.AbstractFactory factoryB = new Patterns.Creational.AbstractFactory.ConcreteFactoryB();
            Patterns.Creational.AbstractFactory.Client clientB = new Patterns.Creational.AbstractFactory.Client(factoryB);
            clientB.Run();

            // Ожидание ввода
            Console.ReadKey();
        }

        static void TestBuilder()
        {
            // Create director and builders
            Patterns.Creational.Builder.Director director = new Patterns.Creational.Builder.Director();

            Patterns.Creational.Builder.Builder bA = new Patterns.Creational.Builder.ConcreteBuilderA();
            Patterns.Creational.Builder.Builder bB = new Patterns.Creational.Builder.ConcreteBuilderB();

            // Construct two products
            director.Construct(bA);
            Patterns.Creational.Builder.Product p1 = bA.GetResult();
            p1.Show();

            director.Construct(bB);
            Patterns.Creational.Builder.Product p2 = bB.GetResult();
            p2.Show();

            // Wait for user
            Console.ReadKey();
        }

        static void TestDependencyInjection() { }

        static void TestFactoryMethod()
        {
            // an array of creators
            Patterns.Creational.FactoryMethod.Creator[] creators = { new Patterns.Creational.FactoryMethod.ConcreteCreatorA(), new Patterns.Creational.FactoryMethod.ConcreteCreatorB() };
            // iterate over creators and create products
            foreach (Patterns.Creational.FactoryMethod.Creator creator in creators)
            {
                Patterns.Creational.FactoryMethod.Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType());
            }

            // Wait for user
            Console.ReadKey();
        }

        static void TestLazyInitialization()
        {
            Patterns.Creational.LazyInitialization.Fruit.GetFruitByTypeName("Banana");
            Patterns.Creational.LazyInitialization.Fruit.ShowAll();

            Patterns.Creational.LazyInitialization.Fruit.GetFruitByTypeName("Apple");
            Patterns.Creational.LazyInitialization.Fruit.ShowAll();

            // returns pre-existing instance from first 
            // time Fruit with "Banana" was created
            Patterns.Creational.LazyInitialization.Fruit.GetFruitByTypeName("Banana");
            Patterns.Creational.LazyInitialization.Fruit.ShowAll();

            Console.ReadKey();
        }

        static void TestMultiton()
        {
            Patterns.Creational.Multiton.Multiton m0 = Patterns.Creational.Multiton.Multiton.GetInstance(Patterns.Creational.Multiton.MultitonType.ZERO);
            Patterns.Creational.Multiton.Multiton m1 = Patterns.Creational.Multiton.Multiton.GetInstance(Patterns.Creational.Multiton.MultitonType.ONE);
            Patterns.Creational.Multiton.Multiton m2 = Patterns.Creational.Multiton.Multiton.GetInstance(Patterns.Creational.Multiton.MultitonType.TWO);
            System.Console.WriteLine(m0);
            System.Console.WriteLine(m1);
            System.Console.WriteLine(m2);

            // Wait for user
            Console.ReadKey();
        }

        static void TestObjectPool() { }
        static void TestPrototype() { }
        static void TestResourceAcquisitionIsInitialization() { }
        static void TestSingleton() { }

        #endregion

        #region Structural pattern tests

        static void TestAdapter() { }
        static void TestBridge() { }
        static void TestComposite() { }
        static void TestDecorator() { }
        static void TestExtensionObject() { }
        static void TestFacade() { }
        static void TestFlyweight() { }
        static void TestFrontController() { }
        static void TestMarker() { }
        static void TestModule() { }
        static void TestProxy() { }
        static void TestTwin() { }

        #endregion

        #region Behavioral pattern tests

        static void TestBlackboard() { }
        static void TestChainOfResponsibility() { }
        static void TestCommand() { }
        static void TestInterpreter() { }
        static void TestIterator() { }
        static void TestMediator() { }
        static void TestMemento() { }
        static void TestNullObject() { }
        static void TestObserver() { }
        static void TestServant() { }
        static void TestSpecification() { }
        static void TestState() { }
        static void TestStrategy() { }
        static void TestTemplateMethod() { }
        static void TestVisitor() { }

        #endregion

        #region Concurency pattern tests

        static void TestActiveObject() { }
        static void TestBalking() { }
        static void TestBindingProperties() { }
        static void TestComputeKernel() { }
        static void TestDoubleCheckedLocking() { }
        static void TestEventBasedAsynchronous() { }
        static void TestGuardedSuspension() { }
        static void TestJoin() { }
        static void TestLock() { }
        static void TestMessagingDesignPattern() { }
        static void TestMonitorObject() { }
        static void TestReactor() { }
        static void TestReadWriteLock() { }
        static void TestThreadPool() { }
        static void TestThreadSpecificStorage() { }

        #endregion

        #region Pattern types tests

        static void TestCreationalPatterns()
        {
            TestAbstractFactory();
            TestBuilder();
            TestDependencyInjection();
            TestFactoryMethod();
            TestLazyInitialization();
            TestMultiton();
            TestObjectPool();
            TestPrototype();
            TestResourceAcquisitionIsInitialization();
            TestSingleton();
        }

        static void TestStructuralPatterns()
        {
            TestAdapter();
            TestBridge();
            TestComposite();
            TestDecorator();
            TestExtensionObject();
            TestFacade();
            TestFlyweight();
            TestFrontController();
            TestMarker();
            TestModule();
            TestProxy();
            TestTwin();
        }

        static void TestBehavioralPatterns()
        {
            TestBlackboard();
            TestChainOfResponsibility();
            TestCommand();
            TestInterpreter();
            TestIterator();
            TestMediator();
            TestMemento();
            TestNullObject();
            TestObserver();
            TestServant();
            TestSpecification();
            TestState();
            TestStrategy();
            TestTemplateMethod();
            TestVisitor();
        }

        static void TestConcurencyPatterns()
        {
            TestActiveObject();
            TestBalking();
            TestBindingProperties();
            TestComputeKernel();
            TestDoubleCheckedLocking();
            TestEventBasedAsynchronous();
            TestGuardedSuspension();
            TestJoin();
            TestLock();
            TestMessagingDesignPattern();
            TestMonitorObject();
            TestReactor();
            TestReadWriteLock();
            TestThreadPool();
            TestThreadSpecificStorage();
        }

        #endregion

        #region Main

        static void Main()
        {
            TestCreationalPatterns();
            TestStructuralPatterns();
            TestBehavioralPatterns();
            TestConcurencyPatterns();
        }

        #endregion
    }
}
