namespace CompoundPatterns;

internal abstract class AbstractDuckFactory
{
    internal abstract IQuackable CreateMallardDuck();
    internal abstract IQuackable CreateRedheadDuck();
    internal abstract IQuackable CreateDuckCall();
    internal abstract IQuackable CreateRubberDuck();

    internal abstract IQuackable CreateGooseDuck();
}