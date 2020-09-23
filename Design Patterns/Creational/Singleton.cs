using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational
{
    class Singleton
    {
        private static FurnitureFactory furnitureFactory;
        private static ElectronicsFactory electronicsFactory;
        protected Singleton()
        {

        }


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
