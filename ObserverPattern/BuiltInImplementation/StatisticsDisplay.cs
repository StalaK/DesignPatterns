namespace ObserverPattern.BuiltInImplementation;

internal class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
{
    private decimal _averageTemperature;
    private decimal _minTemp;
    private decimal _maxTemp;

    private int _readingCount;
    private decimal _totalTemp;

    private IDisposable? _cancellation;

    public StatisticsDisplay(WeatherData data)
    {
        _minTemp = Decimal.MaxValue;
        _maxTemp = Decimal.MinValue;
        Subscribe(data);
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Weather Stats");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Avg Temp: {_averageTemperature}C\nMax Temp: {_maxTemp}C\nMin Temp: {_minTemp}C\n");
    }

    public void OnCompleted()
    {
        Console.WriteLine("The provider has finished sending notifications");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("An error occurred");
    }

    public void OnNext(WeatherData value)
    {
        _totalTemp += value.Temperature;
        _readingCount++;

        _averageTemperature = _totalTemp / _readingCount;
        _maxTemp = Math.Max(_maxTemp, value.Temperature);
        _minTemp = Math.Min(_minTemp, value.Temperature);

        Display();
    }

    public virtual void Subscribe(WeatherData provider) => _cancellation = provider.Subscribe(this);

    public virtual void Unsubscribe() => _cancellation?.Dispose();
}
