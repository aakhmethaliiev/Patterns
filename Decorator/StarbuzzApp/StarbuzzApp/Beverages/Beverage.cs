namespace StarbuzzApp.Beverages
{
    public abstract class Beverage
    {
        private string _description;

        public string Description
        {
            set => _description = value;
        }

        public virtual string GetDescription()
        {
            return _description;
        }
        public abstract double Cost();
    }
}