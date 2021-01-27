namespace Design_Patterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete Subject of interest
    /// </summary>
    public class Stock: AStock
    {
        public Stock(string name, double price)
            : base(name, price)
        {
            
        }
    }



}
