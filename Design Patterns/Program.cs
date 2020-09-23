using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Creational.Builder;

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
            LaptopBuilder builder = new LaptopBuilder();
            LaptopManager manager = new LaptopManager(builder);

            manager.BuildProduct();
            Laptop laptop = manager.GetProduct();
            Println(laptop.ToString());
        }
    }

}
