using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Behavioral.Observer;

namespace Design_Patterns
{
    class Program
    {
        static public void Println<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            Stock stock = new Stock("Microsoft", 120);
            stock.Attach(new Investor("Bill Gates"));
            stock.Attach(new Investor("Someone"));

            stock.Price = 33.33;
            Console.ReadKey();
            stock.Price = 32.99;
        }
    }

}
