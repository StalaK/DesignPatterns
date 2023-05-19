namespace CompoundPatterns;

internal interface IObserver
{
    public void Update(IQuackObservable duck);
}