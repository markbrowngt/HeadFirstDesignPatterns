namespace DecoratorPattern
{
    public enum BeverageSize
    {
        TALL, GRANDE, VENTI
    }

    public abstract class Beverage
    {
        private string _description = "Unknown Beverage";
        private BeverageSize _size = BeverageSize.TALL;
        public virtual string Description 
        { 
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            } 
        }

        public virtual BeverageSize Size
        {
            get 
            {
                return _size;
            }
            set 
            {
                _size = value;
            }
        }
        
        public abstract double Cost();
    }
}