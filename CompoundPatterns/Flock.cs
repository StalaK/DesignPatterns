namespace CompoundPatterns;

internal class Flock : IQuackable
{
    private readonly List<IQuackable> _quackers;

    public Flock()
    {
        _quackers = new();
    }

    internal void Add(IQuackable duck)
    {
        _quackers.Add(duck);
    }

    public void Quack()
    {
        foreach (var duck in _quackers)
        {
            duck.Quack();
        }
    }

    public void NotifyObservers()
    {
        // Each IQuackable will perform its own notify
    }

    public void RegisterObserver(IObserver observer)
    {
        foreach (var duck in _quackers)
        {
            duck.RegisterObserver(observer);
        }
    }
}