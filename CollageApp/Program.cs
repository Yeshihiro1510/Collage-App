Console.WriteLine("Strategy");
IStrategy strategy1 = new ConcreteStrategy1();
Context context = new Context(strategy1);
Console.Write("Выполнение со Стратегией 1: ");
context.ExecuteAlgorithm();

IStrategy strategy2 = new ConcreteStrategy2();
context.ContextStrategy = strategy2;
Console.Write("Выполнение со Стратегией 2: ");
context.ExecuteAlgorithm();
Console.WriteLine();



Console.WriteLine("Command");
Receiver receiver = new Receiver();
Command command = new ConcreteCommand(receiver);
Invoker invoker = new Invoker();
invoker.SetCommand(command);

Console.Write("Вызов invoker.Run(): ");
invoker.Run();

Console.Write("Вызов invoker.Cancel(): ");
invoker.Cancel();
Console.WriteLine();



Console.WriteLine("Chain of responsibility");
Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
h1.Successor = h2;

Console.Write("Передаем 5 (ожидаем обработку в Handler1): ");
h1.HandleRequest(5);

Console.Write("Передаем 15 (ожидаем обработку в Handler2): ");
h1.HandleRequest(15);
Console.WriteLine();
