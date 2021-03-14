using System;
using System.Collections.Generic;
using System.Text;
using Design_Patterns.Creational;


namespace Design_Patterns.Creational
{
    public class SingletonPatternApp
    {
        public SingletonPatternApp()
        {
            var electronicsFactory = Singleton.GetElectronicsFactory();
            var furnitureFactory = Singleton.GetFurnitureFactory();
            Laptop myLaptop = electronicsFactory.MakeLaptop("Asus VivoBook S15", 400, "VivoBook S15", "Asus");


            Console.WriteLine(myLaptop.ToString());
            Console.WriteLine(furnitureFactory.CreateChair("Master", 34).ToString());
        }

    }
    sealed class Singleton
    {
        private static FurnitureFactory furnitureFactory;
        private static ElectronicsFactory electronicsFactory;

        public static FurnitureFactory GetFurnitureFactory()
        {
            if(furnitureFactory == null)
            {
                furnitureFactory = new FurnitureFactory();
            }
            return furnitureFactory;
        }

        public static ElectronicsFactory GetElectronicsFactory()
        {
            if(electronicsFactory == null)
            {
                electronicsFactory = new ElectronicsFactory();
            }
            return electronicsFactory;
        }
    }
}
