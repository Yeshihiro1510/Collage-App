namespace CollageApp;

public class Vehicle(float worth, int engineVolume) : Property(worth)
{
    protected readonly int _engineVolume = engineVolume;

    public override float CalculateTax() => _worth * _engineVolume / 3000;
    public override string ToString() => $"{GetType().Name}: worth: {_worth}, tax: {CalculateTax()} , squares: {_engineVolume}cb.sm.";
}

public class Car(float worth, int engineVolume) : Vehicle(worth, engineVolume)
{
    
}

public class Boat(float worth, int engineVolume) : Vehicle(worth, engineVolume)
{
    
}