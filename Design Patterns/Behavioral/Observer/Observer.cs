using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.Observer
{
    /// <summary>
    /// Define a one-to-many dependency between objects so that when one object changes state,
    /// all its dependents are notified and updated automatically.
    /// </summary>
    class Observer
    {

    }

    /**
     * Subject
     * Concrete Subject
     * Observer
     * Concrete Observer
     */

    // Object of interest
    abstract class AStock
    {
        private readonly string _label;
        private double _price;
        // Observers
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

    // Concrete interest
    class Stock: AStock
    {
        public Stock(string name, double price)
            : base(name, price)
        {
            
        }
    }

    // Observer
    interface IInvestor
    {
        void Update(AStock stock);
    }

    class Investor : IInvestor
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
