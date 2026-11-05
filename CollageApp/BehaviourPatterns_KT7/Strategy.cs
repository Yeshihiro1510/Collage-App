using System;

public interface IStrategy
{
    void Algorithm();
}

public class ConcreteStrategy1 : IStrategy
{
    public ConcreteStrategy1()
    {
    }

    public void Algorithm()
    {
        Console.WriteLine("ConcreteStrategy1.Algorithm");
    }
}

public class ConcreteStrategy2 : IStrategy
{
    public ConcreteStrategy2()
    {
    }

    public void Algorithm()
    {
        Console.WriteLine("ConcreteStrategy2.Algorithm");
    }
}

public class Context
{
    public IStrategy ContextStrategy { get; set; }

    public Context(IStrategy _strategy)
    {
        this.ContextStrategy = _strategy;
    }

    public void ExecuteAlgorithm()
    {
        if (ContextStrategy != null)
        {
            ContextStrategy.Algorithm();
        }
    }
}
