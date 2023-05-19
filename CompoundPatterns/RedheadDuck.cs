namespace CompoundPatterns;

internal class RedheadDuck : IQuackable
{
    private readonly Observable _observable;

    public RedheadDuck()
    {
        _observable = new(this);
    }

    public void Quack()
    {
        Console.WriteLine("Quack");
        NotifyObservers();
    }

    public void NotifyObservers() => _observable.NotifyObservers();

    public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);
}