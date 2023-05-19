namespace CompoundPatterns;

internal interface IQuackObservable
{
    public void RegisterObserver(IObserver observer);
    public void NotifyObservers();
}
