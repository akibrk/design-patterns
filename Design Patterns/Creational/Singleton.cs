using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational
{
    class Singleton
    {
        private readonly FurnitureFactory furnitureFactory;
        private readonly ElectronicsFactory electronicsFactory;
        public Singleton()
        {
            furnitureFactory = new FurnitureFactory();
            electronicsFactory = new ElectronicsFactory();
        }


        public FurnitureFactory GetFurnitureFactory()
        {
            return furnitureFactory;
        }

        public ElectronicsFactory GetElectronicsFactory()
        {
            return electronicsFactory;
        }

        /* Main
         * Singleton singleton = new Singleton();
            var factory1 = singleton.GetElectronicsFactory();
            var furnitureFac = singleton.GetFurnitureFactory();
            Laptop myLaptop = factory1.MakeLaptop("Asus VivoBook S15", 400, "VivoBook S15", "Asus");


            Println(myLaptop.ToString());
            Println(furnitureFac.CreateChair("Master", 34).ToString());
         
         */
    }
}
