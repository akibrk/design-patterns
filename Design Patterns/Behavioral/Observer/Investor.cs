using System;

namespace Design_Patterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete observer
    /// </summary>
    public class Investor : IInvestor
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(AStock stock)
        {
            Console.WriteLine($"{_name} \t{stock.Label}\t{stock.Price}\t{ DateTime.Now } ");
        }
    }



}
