public class MusicStation
{
    public bool IsTurnedOn { get; private set; }
    public string Music { get; private set; } = "None";

    public void Switch()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void SetMusic(string music)
    {
        Music = music;
    }

    public override string ToString()
    {
        return $"MusicStation: IsTurnedOn={IsTurnedOn}, Music={Music}";
    }
}
