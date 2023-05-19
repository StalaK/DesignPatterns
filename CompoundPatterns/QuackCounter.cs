namespace CompoundPatterns;

internal class QuackCounter : IQuackable
{
    private readonly IQuackable _duck;
    public static int NumberOfQuacks { get; private set; }
    private readonly Observable _observable;

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
        _observable = new(this);
    }

    public void Quack()
    {
        _duck.Quack();
        NumberOfQuacks++;
        NotifyObservers();
    }

    public void NotifyObservers() => _observable.NotifyObservers();

    public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);
}