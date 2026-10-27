namespace CollageApp.GenerativePatternsTask_KT6
{
    public interface IAbstractFactory
    {
        public ProductA CreateProductA();
        public ProductB CreateProductB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public ProductA CreateProductA() => new ProductA1();

        public ProductB CreateProductB()=> new ProductB1();
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public ProductA CreateProductA()=>new ProductA2();

        public ProductB CreateProductB()=>new ProductB2();
    }

    public abstract class ProductA
    {
    }

    public abstract class ProductB
    {
    }

    public class ProductA1 : ProductA
    {
    }

    public class ProductA2 : ProductA
    {
    }

    public class ProductB1 : ProductB
    {
    }

    public class ProductB2 : ProductB
    {
    }

    public class AbstractFactoryClient
    {
        private ProductA _productA;
        private ProductB _productB;

        public AbstractFactoryClient(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            Console.WriteLine(_productA);
            Console.WriteLine(_productB);
        }
    }
}
