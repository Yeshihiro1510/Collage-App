using System.Numerics;
using CollageApp;

// Упаковка и распаковка

var objects = new object[15];
for (var i = 0; i < objects.Length; i++)
{
    objects[i] = Random.Shared.Next(2) switch
    {
        0 => Random.Shared.Next(-100, 100),
        1 => Random.Shared.NextSingle() * 200f - 100f,
        // 2 => string.Empty,
        _ => throw new ArgumentOutOfRangeException()
    };
}

Console.WriteLine(ArraySum(objects));

float ArraySum(object[] array)
{
    var sum = 0f;

    foreach (var obj in array)
    {
        // Console.WriteLine(obj.GetType());
        if (obj is not (int or float)) continue;
        var value = Convert.ToSingle(obj);
        sum += value;
    }

    return sum;
}

// Обобщенный класс

var stringBook = new Book<string>("Elements of Game Design", 300, "Robert Zubek", "u746TTq9pO");
var intBook = new Book<int>("Brain of the player", 431, "Selia Hodent", 444000);
var guidBook = new Book<Guid>("Game as business", 250, "Alexey Savchenko", Guid.NewGuid());

Console.WriteLine(stringBook);
Console.WriteLine(intBook);
Console.WriteLine(guidBook);

// Значения по умолчанию

var intGeneric = new GenericClass<int>(15);
var bookGeneric = new GenericClass<Book<string>>(stringBook);

Console.WriteLine(intGeneric.Value);
Console.WriteLine(bookGeneric.Value);

intGeneric.Reset();
bookGeneric.Reset();

Console.WriteLine(intGeneric.Value);
Console.WriteLine(bookGeneric.Value);

// Обобщенный метод

var intCircle = new Circle<int>(Vector2.Zero, 5);
var stringCircle = new Circle<string>(Vector2.Zero, "7");
var doubleCircle = new Circle<double>(Vector2.Zero, 3.2);
var floatCircle = new Circle<float>(Vector2.Zero, 2.4f);

intCircle.SetRadius(6);
stringCircle.SetRadius("8");
doubleCircle.SetRadius(4.3);
floatCircle.SetRadius(3.5f);

Console.WriteLine($"Radius: {intCircle.Radius}, Area: {intCircle.Area}");
Console.WriteLine($"Radius: {stringCircle.Radius}, Area: {stringCircle.Area}");
Console.WriteLine($"Radius: {doubleCircle.Radius}, Area: {doubleCircle.Area}");
Console.WriteLine($"Radius: {floatCircle.Radius}, Area: {floatCircle.Area}");

// Обобщенный класс с несколькими универсальными параметрами

var firstRectangle = new Rectangle<string, int>(Vector2.Zero, "4", 2);
var secondRectangle = new Rectangle<string, double>(new Vector2(1.5f, 2.5f), "2.5", 3.3);
var thirdRectangle = new Rectangle<string, float>(new Vector2(-2, 3), "3", 4.2f);

Console.WriteLine($"Min: {firstRectangle.MinPoint} Max: {firstRectangle.MaxPoint}");
Console.WriteLine($"Min: {secondRectangle.MinPoint} Max: {secondRectangle.MaxPoint}");
Console.WriteLine($"Min: {thirdRectangle.MinPoint} Max: {thirdRectangle.MaxPoint}");
