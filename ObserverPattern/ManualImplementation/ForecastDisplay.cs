namespace ObserverPattern.ManualImplementation;

internal class ForecastDisplay : IObserver, IDisplayElement
{
    private string _forecast;

    private ISubject _weatherData;

    public ForecastDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);

        _forecast = "Unknown";
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Forecast");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Current forecaset: {_forecast}\n");
    }

    public void Update(decimal temperature, decimal humidity, decimal pressure)
    {
        _forecast = humidity > 75 && pressure > 29 ? "Rain" : "Sun";

        Display();
    }
}