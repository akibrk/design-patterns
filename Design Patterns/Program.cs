using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Structural;

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
            Product laptop = new Product("Asus Vivobook")
            {
                BrokenParts = true,
                WaterDamaged = true
            };

            Facade AsusServiceCenter = new Facade();

            if (AsusServiceCenter.CanReturnProduct(laptop))
            {
                laptop = AsusServiceCenter.FixProduct(laptop);
            }

            if (laptop.Repaired)
            {
                Println("Laptop was repaired");
            }
            else
            {
                Println("Sorry, could not repair the laptop");
            }
        }
    }

}
