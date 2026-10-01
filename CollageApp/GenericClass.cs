namespace CollageApp;

public class GenericClass<T>(T value)
{
    public T Value { get; set; } = value;

    public void Reset() => Value = default;
}