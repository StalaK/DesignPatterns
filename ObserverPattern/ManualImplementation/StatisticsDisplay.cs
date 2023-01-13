namespace ObserverPattern.ManualImplementation;

internal class StatisticsDisplay : IObserver, IDisplayElement
{
    private decimal _averageTemperature;
    private decimal _minTemp;
    private decimal _maxTemp;

    private int _readingCount;
    private decimal _totalTemp;

    private ISubject _weatherData;

    public StatisticsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);

        _minTemp = Decimal.MaxValue;
        _maxTemp = Decimal.MinValue;
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Weather Stats");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Avg Temp: {_averageTemperature}C\nMax Temp: {_maxTemp}C\nMin Temp: {_minTemp}C\n");
    }

    public void Update(decimal temperature, decimal humidity, decimal pressure)
    {
        _totalTemp += temperature;
        _readingCount++;

        _averageTemperature = _totalTemp / _readingCount;
        _maxTemp = Math.Max(_maxTemp, temperature);
        _minTemp = Math.Min(_minTemp, temperature);

        Display();
    }
}
