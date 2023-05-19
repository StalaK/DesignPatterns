namespace CompoundPatterns;

internal class Observable : IQuackObservable
{
    private readonly List<IObserver> _observers;
    private readonly IQuackObservable _duck;

    public Observable(IQuackObservable duck)
    {
        _duck = duck;
        _observers = new();
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_duck);
        }
    }

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);
}