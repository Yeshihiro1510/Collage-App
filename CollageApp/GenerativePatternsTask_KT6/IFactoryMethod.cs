namespace CollageApp.GenerativePatternsTask_KT6
{
    public interface IFactoryMethod
    {
        public Product Create();
    }

    public class ConcreteFactoryMethod1 : IFactoryMethod
    {
        public Product Create() => new ConcreteProduct1();
    }

    public class ConcreteFactoryMethod2 : IFactoryMethod
    {
        public Product Create() => new ConcreteProduct2();
    }

    public abstract class Product
    {
    }

    public class ConcreteProduct1 : Product
    {
    }

    public class ConcreteProduct2 : Product
    {
    }
}