using CollageApp.GenerativePatternsTask_KT6;
using CollageApp.GenerativePatternsTask_KT6.Builder;

// Prototype

IPrototype prototype1 = new ConcretePrototype1(999);
IPrototype prototype2 = new ConcretePrototype2(111);

var prototypeClone1 = prototype1.Clone();
var prototypeClone2 = prototype2.Clone();

Console.WriteLine($"{prototypeClone1.Id} {prototypeClone1 == prototype1}");
Console.WriteLine($"{prototypeClone2.Id} {prototypeClone2 == prototype2}");

// Factory method

IFactoryMethod creator1 = new ConcreteFactoryMethod1();
IFactoryMethod creator2 = new ConcreteFactoryMethod2();

CollageApp.GenerativePatternsTask_KT6.Product product1 = creator1.Create();
CollageApp.GenerativePatternsTask_KT6.Product product2 = creator2.Create();

Console.WriteLine(product1);
Console.WriteLine(product2);

// Abstract factory

IAbstractFactory factory1 =  new ConcreteFactory1();
IAbstractFactory factory2 = new ConcreteFactory2();

var client = new AbstractFactoryClient(factory1);

client.Run();

// Builder

IBuilder builder = new ConcreteBuilder();

var director = new Director(builder);

CollageApp.GenerativePatternsTask_KT6.Builder.Product product = director.Construct();

Console.WriteLine(product);