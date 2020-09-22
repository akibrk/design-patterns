using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Creational;

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
            Singleton singleton = new Singleton();
            var factory1 = singleton.GetElectronicsFactory();
            var furnitureFac = singleton.GetFurnitureFactory();
            Laptop myLaptop = factory1.MakeLaptop("Asus VivoBook S15", 400, "VivoBook S15", "Asus");


            Println(myLaptop.ToString());
            Println(furnitureFac.CreateChair("Master", 34).ToString());
        }
    }

}
