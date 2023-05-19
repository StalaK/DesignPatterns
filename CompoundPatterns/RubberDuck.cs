namespace CompoundPatterns;

internal class RubberDuck : IQuackable
{
    private readonly Observable _observable;

    public RubberDuck()
    {
        _observable = new(this);
    }

    public void Quack()
    {
        Console.WriteLine("Squeak!");
        NotifyObservers();
    }

    public void NotifyObservers() => _observable.NotifyObservers();


    public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);
}