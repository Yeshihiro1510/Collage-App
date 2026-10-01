using CollageApp;

var stringBook = new Book<string>("Elements of Game Design", 300, "Robert Zubek", "u746TTq9pO");
var intBook = new Book<int>("Brain of the player", 431, "Selia Hodent", 444000);
var guidBook = new Book<Guid>("Game as business", 250, "Alexey Savchenko", Guid.NewGuid());

Console.WriteLine(stringBook);
Console.WriteLine(intBook);
Console.WriteLine(guidBook);

return;