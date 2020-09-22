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

    }
}
