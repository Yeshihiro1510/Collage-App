namespace CollageApp;

public static class NumberedNameGenerator<T>
{
    private static int _times = 1;

    public static string GenerateNextName()
    {
        var name = $"{typeof(T).Name} {_times}";
        _times++;
        return name;
    }
}