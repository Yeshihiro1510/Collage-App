namespace CollageApp.GenerativePatternsTask_KT6.Builder
{
    public interface IBuilder
    {
        public IBuilder BuildPartA();
        public IBuilder BuildPartB();
        public IBuilder BuildPartC();
        public Product GetResult();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new();

        public IBuilder BuildPartA()
        {
            _product.Add("A");
            return this;
        }

        public IBuilder BuildPartB()
        {
            _product.Add("B");
            return this;
        }

        public IBuilder BuildPartC()
        {
            _product.Add("C");
            return this;
        }

        public Product GetResult()
        {
            return _product;
        }
    }

    public class Product
    {
        private List<object> _parts = [];

        public void Add(string part) => _parts.Add(part);
        public override string ToString()
        {
            return string.Concat(_parts);
        }
    }

    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public Product Construct()=>_builder.BuildPartA().BuildPartB().BuildPartC().GetResult();
    }
}
