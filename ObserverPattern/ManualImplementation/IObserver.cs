namespace ObserverPattern.ManualImplementation;

internal interface IObserver
{
    void Update(decimal temperature, decimal humidity, decimal pressure);
}
