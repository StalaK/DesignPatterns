namespace CompoundPatterns;

internal class CountingDuckFactory : AbstractDuckFactory
{
    // Wraps (decorates) all IQuackables with a QuackCounter so the duck simulator won't know the difference

    internal override IQuackable CreateDuckCall() => new QuackCounter(new DuckCall());

    internal override IQuackable CreateMallardDuck() => new QuackCounter(new MallardDuck());

    internal override IQuackable CreateRedheadDuck() => new QuackCounter(new RedheadDuck());

    internal override IQuackable CreateRubberDuck() => new QuackCounter(new RubberDuck());

    // Don't wrap the goose with the quackcounter, because geese don't quack
    internal override IQuackable CreateGooseDuck() => new GooseAdapter(new Goose());
}