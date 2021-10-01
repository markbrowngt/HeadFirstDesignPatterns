namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description { get => $"{_beverage.Description}, Soy";}

        public override double Cost()
        {
            double soyCost = 0.0;

            switch(_beverage.Size)
            {
                case BeverageSize.TALL:
                    soyCost = .10;
                    break;
                case BeverageSize.GRANDE:
                    soyCost = .15;
                    break;
                case BeverageSize.VENTI:
                    soyCost = .20;
                    break;
            }

            return _beverage.Cost() + soyCost;
        }
    }
}