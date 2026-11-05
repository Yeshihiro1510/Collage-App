public class SmartHome
{
    private Light _light = new Light();
    private TV _tv = new TV();
    private AirConditioner _ac = new AirConditioner();
    private MusicStation _musicStation = new MusicStation();

    public void SetUpHome(string mode)
    {
        Console.WriteLine($"=== АКТИВАЦИЯ РЕЖИМА: {mode.ToUpper()} ===");

        switch (mode.ToLower())
        {
            case "ночной":
                if (_light.IsTurnedOn) _light.SwitchLight();
                if (_tv.IsTurnedOn) _tv.SwitchTV();
                if (!_ac.IsTurnedOn) _ac.Switch();
                _ac.SetTemperature(20);
                if (!_musicStation.IsTurnedOn) _musicStation.Switch();
                _musicStation.SetMusic("Lofi Hip Hop");
                break;

            case "вечеринка":
                if (!_light.IsTurnedOn) _light.SwitchLight();
                _light.ChangeBrightness(100);
                _light.ChangeColor("Neon Purple");
                if (!_tv.IsTurnedOn) _tv.SwitchTV();
                _tv.TurnOnProgram("Music Videos YouTube");
                if (!_ac.IsTurnedOn) _ac.Switch();
                _ac.SetTemperature(18);
                if (!_musicStation.IsTurnedOn) _musicStation.Switch();
                _musicStation.SetMusic("Dance Hits");
                break;

            case "доброе утро":
                if (!_light.IsTurnedOn) _light.SwitchLight();
                _light.ChangeBrightness(40);
                _light.ChangeColor("Warm Yellow");
                if (!_tv.IsTurnedOn) _tv.SwitchTV();
                _tv.TurnOnProgram("Утренние Новости");
                if (_ac.IsTurnedOn) _ac.Switch();
                if (!_musicStation.IsTurnedOn) _musicStation.Switch();
                _musicStation.SetMusic("Acoustic Morning");
                break;

            case "собираюсь на пары":
                if (!_light.IsTurnedOn) _light.SwitchLight();
                _light.ChangeBrightness(80);
                _light.ChangeColor("White");
                if (_tv.IsTurnedOn) _tv.SwitchTV();
                if (_ac.IsTurnedOn) _ac.Switch();
                if (!_musicStation.IsTurnedOn) _musicStation.Switch();
                _musicStation.SetMusic("Energetic Pop");
                break;

            case "ухожу":
                if (_light.IsTurnedOn) _light.SwitchLight();
                if (_tv.IsTurnedOn) _tv.SwitchTV();
                if (_ac.IsTurnedOn) _ac.Switch();
                if (_musicStation.IsTurnedOn) _musicStation.Switch();
                break;

            case "один дома":
                if (!_light.IsTurnedOn) _light.SwitchLight();
                _light.ChangeBrightness(60);
                _light.ChangeColor("Soft Blue");
                if (!_tv.IsTurnedOn) _tv.SwitchTV();
                _tv.TurnOnProgram("Netflix");
                if (!_ac.IsTurnedOn) _ac.Switch();
                _ac.SetTemperature(22);
                if (_musicStation.IsTurnedOn) _musicStation.Switch();
                break;

            default:
                Console.WriteLine("Режим не распознан.");
                return;
        }

        Console.WriteLine(_light.ToString());
        Console.WriteLine(_tv.ToString());
        Console.WriteLine(_ac.ToString());
        Console.WriteLine(_musicStation.ToString());
        Console.WriteLine();
    }
}