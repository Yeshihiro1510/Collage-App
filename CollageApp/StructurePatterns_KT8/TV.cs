public class TV
{
    public bool IsTurnedOn { get; private set; }
    public string Program { get; private set; } = "None";

    public void SwitchTV()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void TurnOnProgram(string program)
    {
        Program = program;
    }

    public override string ToString()
    {
        return $"TV: IsTurnedOn={IsTurnedOn}, Program={Program}";
    }
}
