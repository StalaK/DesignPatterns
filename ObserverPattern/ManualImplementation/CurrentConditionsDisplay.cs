namespace ObserverPattern.ManualImplementation;

internal class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private decimal _temperature;
    private decimal _humidity;
    private ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Current Conditions");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{_temperature}C and {_humidity}% humidity\n");
    }

    public void Update(decimal temperature, decimal humidity, decimal pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        Display();
    }
}
