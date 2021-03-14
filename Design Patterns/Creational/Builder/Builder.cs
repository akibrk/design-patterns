using System.Collections.Generic;
using System;

namespace Design_Patterns.Creational.Builder
{
    class BuilderPatternApp
    {
        public BuilderPatternApp()
        {
            LaptopBuilder builder = new LaptopBuilder();
            LaptopManager manager = new LaptopManager(builder);

            manager.BuildProduct();
            Laptop laptop = manager.GetProduct();
            Console.WriteLine(laptop.ToString());
        }
    }
}
