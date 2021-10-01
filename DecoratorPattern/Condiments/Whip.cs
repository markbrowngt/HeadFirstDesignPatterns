namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description { get => $"{_beverage.Description}, Whip";}

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}