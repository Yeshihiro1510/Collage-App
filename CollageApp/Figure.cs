using System.Numerics;

namespace CollageApp;

public class Figure(Vector2 center)
{
    protected Vector2 _center = center;

    public Vector2 MinPoint { get; } 
    public Vector2 MaxPoint { get; }
}

public class Circle<T>(Vector2 center, T radius) : Figure(center)
{
    public T Radius { get; private set; } = radius;
    public double Area => Math.PI * Math.Pow(Convert.ToDouble(Radius), 2);
    public new Vector2 MinPoint
    {
        get
        {
            var radiusCenter = Convert.ToSingle(Radius) / 2;
            return _center + new Vector2(-radiusCenter, -radiusCenter);
        }
    }
    public new Vector2 MaxPoint
    {
        get
        {
            var radiusCenter = Convert.ToSingle(Radius) / 2;
            return _center + new Vector2(radiusCenter, radiusCenter);
        }
    }

    public void SetRadius(T radius) => Radius = radius;
}

public class Rectangle<T, T2>(Vector2 center, T width, T2 height) : Figure(center)
{
    protected T _width = width;
    protected T2 _height = height;
    
    public new Vector2 MinPoint => _center + new Vector2(-Convert.ToSingle(_width), -Convert.ToSingle(_height));
    public new Vector2 MaxPoint => _center + new Vector2(Convert.ToSingle(_width), Convert.ToSingle(_height));
}

public class Square<T>(Vector2 center, T area) : Rectangle<T, T>(center, area, area)
{
}