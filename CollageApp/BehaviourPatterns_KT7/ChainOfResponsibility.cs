using System;

public abstract class Handler
{
    public Handler Successor { get; set; }

    public Handler()
    {
    }

    public abstract void HandleRequest(int condition);
}

public class ConcreteHandler1 : Handler
{
    public ConcreteHandler1() : base()
    {
    }

    public override void HandleRequest(int condition)
    {
        if (condition < 10)
        {
            Console.WriteLine(condition);
        }
        else if (Successor != null)
        {
            Successor.HandleRequest(condition);
        }
    }
}

public class ConcreteHandler2 : Handler
{
    public ConcreteHandler2() : base()
    {
    }

    public override void HandleRequest(int condition)
    {
        if (condition >= 10)
        {
            Console.WriteLine(condition);
        }
        else if (Successor != null)
        {
            Successor.HandleRequest(condition);
        }
    }
}

public class Client
{
    public Client()
    {
    }

    private static void Main()
    {
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        h1.Successor = h2;

        h1.HandleRequest(5);
        h1.HandleRequest(15);
    }
}
