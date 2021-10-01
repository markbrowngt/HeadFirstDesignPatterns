namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}