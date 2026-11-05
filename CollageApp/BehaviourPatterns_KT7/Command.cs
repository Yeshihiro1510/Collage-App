using System;

public class Receiver
{
    public Receiver()
    {
    }

    public void Operaiton()
    {
        Console.WriteLine("Receiver.Operaiton");
    }
}

public abstract class Command
{
    public Command()
    {
    }

    public abstract void Execute();
    public abstract void Undo();
}

public class ConcreteCommand : Command
{
    private Receiver receiver;

    public ConcreteCommand(Receiver r) : base()
    {
        this.receiver = r;
    }

    public override void Execute()
    {
        receiver.Operaiton();
    }

    public override void Undo()
    {
        Console.WriteLine("ConcreteCommand.Undo");
    }
}

public class Invoker
{
    private Command command;

    public Invoker()
    {
    }

    public void SetCommand(Command c)
    {
        this.command = c;
    }

    public void Run()
    {
        if (command != null)
        {
            command.Execute();
        }
    }

    public void Cancel()
    {
        if (command != null)
        {
            command.Undo();
        }
    }
}

public class Client2
{
    public Client2()
    {
    }

    private static void Main()
    {
        Receiver receiver = new Receiver();
        Command command = new ConcreteCommand(receiver);

        Invoker invoker = new Invoker();
        invoker.SetCommand(command);

        invoker.Run();
        invoker.Cancel();
    }
}
