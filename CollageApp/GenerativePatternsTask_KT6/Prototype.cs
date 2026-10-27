namespace CollageApp.GenerativePatternsTask_KT6
{
    public abstract class Prototype(int id)
    {
        public int Id { get => id; protected set => id = value; }
        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id)
        {
        }

        public override Prototype Clone() => new ConcretePrototype1(Id);
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id)
        {
        }

        public override Prototype Clone() => new ConcretePrototype2(Id);
    }
}