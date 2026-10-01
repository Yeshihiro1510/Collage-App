using System.Numerics;

namespace CollageApp;

public class Figure
{
    public Vector2 Center;

    public Figure()
    {
    }
}

public class Circle<T>(T radius)
{
    public T Radius { get; private set; } = radius;
    public double Area => Math.PI * Math.Pow(Convert.ToDouble(Radius), 2);

    public void SetRadius(T radius) => Radius = radius;
}