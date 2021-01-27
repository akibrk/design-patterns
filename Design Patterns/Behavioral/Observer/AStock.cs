using System;
using System.Collections.Generic;

namespace Design_Patterns.Behavioral.Observer
{
    /// <summary>
    /// Subject of interest
    /// </summary>
    public abstract class AStock
    {
        private readonly string _label;
        private double _price;

        // Observers/Subcribers
        private readonly List<IInvestor> _investors = new List<IInvestor>();

        public AStock(string label, double price)
        {
            _label = label;
            _price = price;
        }

        // Add new observer
        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }
        // Remove observer
        public void Remove(IInvestor investor)
        {
            _investors.Remove(investor);
        }
        // Notify
        public void Notify()
        {
            Console.WriteLine($"Investor\tStock\t\tPrice\tTime");
            Console.WriteLine("********************************************************");
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
            Console.WriteLine();
        }


        public string Label { get { return _label; } }
        public double Price {
            get { return _price; }
            set
            {
                if(_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
    }



}
