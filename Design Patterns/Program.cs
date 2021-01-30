using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Structural.Proxy;

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
            // Run observer example
            //_ = new Observer();

            // Run Proxy example

            _ = new Proxy();

        }
    }

}
