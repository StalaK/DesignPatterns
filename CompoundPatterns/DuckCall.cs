namespace CompoundPatterns;

internal class DuckCall : IQuackable
{
    private readonly Observable _observable;

    public DuckCall()
    {
        _observable = new(this);
    }

    public void Quack()
    {
        // A duck call that quacks, but doesn't sound like the real thing
        Console.WriteLine("Kwak");
        NotifyObservers();
    }

    public void NotifyObservers() => _observable.NotifyObservers();

    public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);
}