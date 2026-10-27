namespace CollageApp.GenerativePatternsTask_KT6
{
    public interface IPrototype
    {
        public int Id { get; }
        public abstract IPrototype Clone();
    }

    public class ConcretePrototype1(int id) : IPrototype
    {
        public int Id => id;

        public IPrototype Clone() => new ConcretePrototype1(id);
    }

    public class ConcretePrototype2(int id) : IPrototype
    {
        public int Id => id;

        public IPrototype Clone() => new ConcretePrototype2(id);
    }
}