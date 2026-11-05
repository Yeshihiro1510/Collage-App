public class AirConditioner
{
    public bool IsTurnedOn { get; private set; }
    public int Temperature { get; private set; } = 22;

    public void Switch()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void SetTemperature(int temperature)
    {
        Temperature = temperature;
    }

    public override string ToString()
    {
        return $"AirConditioner: IsTurnedOn={IsTurnedOn}, Temperature={Temperature}";
    }
}
