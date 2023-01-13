namespace ObserverPattern.BuiltInImplementation;

internal class GeneralDisplay : IObserver<WeatherData>, IDisplayElement
{
    private decimal _temperature;
    private decimal _humidity;
    private decimal _pressure;

    private IDisposable? _cancellation;

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("General Display");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Temperature: {_temperature}C\nHumidity: {_humidity}%\nPressure: {_pressure}\n");
    }

    // indicates that the provider has finished sending notifications
    public void OnCompleted()
    {
        Console.WriteLine("The provider has finished sending notifications");
    }

    // informs the observer that an error has occurred
    public void OnError(Exception error)
    {
        Console.WriteLine("An error occurred");
    }

    // supplies the observer with new or current information
    public void OnNext(WeatherData value)
    {
        _temperature = value.Temperature;
        _humidity = value.Humidity;
        _pressure = value.Pressure;
        Display();
    }

    public virtual void Subscribe(WeatherData provider) => _cancellation = provider.Subscribe(this);

    public virtual void Unsubscribe() => _cancellation?.Dispose();
}
