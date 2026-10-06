using CollageApp;

ConsoleKey key;
do
{
    Console.WriteLine("Pick the difficulty: 1 2 3");
    key = Console.ReadKey().Key;
    Console.Clear();
}
while (key is not (ConsoleKey.D1 or ConsoleKey.D2 or ConsoleKey.D3));

Enemy[] enemies = new Enemy[key switch
{
    ConsoleKey.D1 => 5,
    ConsoleKey.D2 => 10,
    ConsoleKey.D3 => 15,
    _ => throw new NotImplementedException()
}];
for (var i = 0; i < enemies.Length; i++)
{
    enemies[i] = Random.Shared.Next(2) > 0 ? new Rusher() : new Ranger();
}

Console.WriteLine($"{enemies.Length} enemies spawned");
Console.WriteLine($"{enemies[Random.Shared.Next(enemies.Length)]} has died");
var toClone = enemies[Random.Shared.Next(enemies.Length)];
Console.WriteLine($"{toClone.Clone()} cloned from {toClone}");

return;
