namespace ObserverPattern.BuiltInImplementation;

internal class WeatherData : IObservable<WeatherData>
{
    private readonly List<IObserver<WeatherData>> _observers;


    public decimal Temperature { get; set; }
    public decimal Humidity { get; set; }
    public decimal Pressure { get; set; }

    public WeatherData()
    {
        _observers = new();
    }

    public void SetMeasurements(decimal temperature, decimal humidity, decimal pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;

        NotifyObservers();
    }

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);

            // Can call OnNext at this stage to send current state
            // observer.OnNext(this);
        }

        return new Unsubscriber<WeatherData>(_observers, observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
            observer.OnNext(this);
    }
}
