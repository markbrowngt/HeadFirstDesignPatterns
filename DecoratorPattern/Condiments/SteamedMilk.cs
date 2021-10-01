namespace DecoratorPattern
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description { get => $"{_beverage.Description}, Steamed Milk";}

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}