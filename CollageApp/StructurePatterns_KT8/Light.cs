public class Light
{
    public bool IsTurnedOn { get; private set; }
    public int Brightness { get; private set; }
    public string Color { get; private set; } = "White";

    public void SwitchLight()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void ChangeBrightness(int brightness)
    {
        Brightness = brightness;
    }

    public void ChangeColor(string color)
    {
        Color = color;
    }

    public override string ToString()
    {
        return $"Light: IsTurnedOn={IsTurnedOn}, Brightness={Brightness}, Color={Color}";
    }
}
