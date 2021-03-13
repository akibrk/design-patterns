using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Structural.Proxy;
using Design_Patterns.Behavioral.Command;

using Design_Patterns.Structural.Decorator;

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

            /*_ = new Proxy();*/

            //_ = new CommandPatternApp();

            _ = new DecoratorPatternApp();



        }
    }

}
