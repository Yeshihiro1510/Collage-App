using CollageApp.GenerativePatternsTask_KT6;

Prototype ConcretePrototype1 = new ConcretePrototype1(999);
Prototype ConcretePrototype2 = new ConcretePrototype2(111);

Console.WriteLine(ConcretePrototype1.Clone().Id);
Console.WriteLine(ConcretePrototype2.Clone().Id);