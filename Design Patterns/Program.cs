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
            var factory1 = Singleton.GetElectronicsFactory();
            var furnitureFac = Singleton.GetFurnitureFactory();


            Laptop myLaptop = factory1.MakeLaptop("Asus VivoBook S15", 400, "VivoBook S15", "Asus");


            Println(myLaptop.ToString());
            Println(furnitureFac.CreateChair("Master", 34).ToString());
        }
    }

}
