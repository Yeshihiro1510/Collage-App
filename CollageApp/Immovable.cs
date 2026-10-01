namespace CollageApp;

public class Immovable(float worth, int squares) : Property(worth)
{
    protected readonly int _squares = squares;

    public override float CalculateTax() =>
        _squares switch
        {
            < 100 => _squares / 500f,
            < 300 => _squares / 350f,
            > 300 => _squares / 250f,
            _ => throw new ArgumentOutOfRangeException()
        };

    public float CalculateSquareWorth() => CalculateTax() / _squares;
    public override string ToString() => $"{GetType().Name}: worth: {_worth}, tax: {CalculateTax()} , squares: {_squares}sq.m.";
}

public class Apartment(float worth, int squares) : Immovable(worth, squares)
{
}

public class CountryHouse(float worth, int squares) : Immovable(worth, squares)
{
}