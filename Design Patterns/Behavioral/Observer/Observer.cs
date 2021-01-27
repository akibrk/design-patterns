using System.Text;

namespace Design_Patterns.Behavioral.Observer
{
    /// <summary>
    /// Define a one-to-many dependency between objects so that when one object changes state,
    /// all its dependents are notified and updated automatically.
    /// 
    /// Observers has two major components
    /// 1. Subject
    /// 2. Observer
    /// 
    /// The subject allows the observer to listen for changes of value
    /// </summary>
    public class Observer
    {
        public Observer()
        {
            // Driver Code
            
            var stock = new Stock("PT", 100);

            var pranto = new Investor("Pranto");

            stock.Attach(pranto);

                stock.Price = 112;
                stock.Price = 114;


        }
    }

}
