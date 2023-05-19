namespace CompoundPatterns;

internal class DuckFactory : AbstractDuckFactory
{
    internal override IQuackable CreateDuckCall() => new DuckCall();

    internal override IQuackable CreateMallardDuck() => new MallardDuck();

    internal override IQuackable CreateRedheadDuck() => new RedheadDuck();

    internal override IQuackable CreateRubberDuck() => new RubberDuck();

    internal override IQuackable CreateGooseDuck() => new GooseAdapter(new Goose());
}