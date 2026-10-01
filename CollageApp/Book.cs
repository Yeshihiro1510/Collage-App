namespace CollageApp;

public class Book<T>(string name, uint pages, string author, T id)
{
    public override string ToString() => $"{id}, {name}, {pages}, {author}";
}