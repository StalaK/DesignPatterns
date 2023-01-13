namespace ObserverPattern.ManualImplementation;

internal class WeatherData : ISubject
{
    private readonly List<IObserver> _observers;
    private decimal _temperature;
    private decimal _humidity;
    private decimal _pressure;

    public WeatherData()
    {
        _observers = new();
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }

    public void SetMeasurements(decimal temperature, decimal humidity, decimal pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }

    public void MeasurementsChanged() => NotifyObservers();

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);

    public void RemoveObserver(IObserver observer) => _observers.RemoveAt(_observers.IndexOf(observer));
}
