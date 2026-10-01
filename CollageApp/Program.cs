using CollageApp;

Property[] properties =
[
    new Apartment(500 + Random.Shared.NextSingle() * 10000,Random.Shared.Next(30, 100)),
    new Apartment(500 + Random.Shared.NextSingle() * 10000, Random.Shared.Next(30, 100)),
    new Apartment(500 + Random.Shared.NextSingle() * 10000, Random.Shared.Next(30, 100)),
    new Car(500 + Random.Shared.NextSingle() * 1000, Random.Shared.Next(50, 100)),
    new Car(500 + Random.Shared.NextSingle() * 1000, Random.Shared.Next(50, 100)),
    new Car(500 + Random.Shared.NextSingle() * 1000, Random.Shared.Next(50, 100)),
    new Boat(500 + Random.Shared.NextSingle() * 600, Random.Shared.Next(70, 120)),
    new Boat(500 + Random.Shared.NextSingle() * 600, Random.Shared.Next(70, 120)),
    new CountryHouse(500 + Random.Shared.NextSingle() * 900, Random.Shared.Next(20, 100)),
    new CountryHouse(500 + Random.Shared.NextSingle() * 900, Random.Shared.Next(20, 100)),
];

foreach (var property in properties)
{
    Console.WriteLine(property);
}