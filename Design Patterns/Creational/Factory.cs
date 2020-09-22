using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational
{
    class Factory
    {
        // No need to deal with instantiation 
    }

    // From Abstract factory
    class FurnitureFactory
    {
        public Chair CreateChair(string chairName, decimal chairPrice)
        {
            // Check for name validations, add prefix/postfix
            // Check for price limits etc
            return new Chair(chairName, chairPrice);
        }

        public Table CreateTable(string tableName, decimal tablePrice)
        {
            return new Table(tableName, tablePrice);
        }
    }

    class ElectronicsFactory
    {
        public Laptop MakeLaptop(string deviceName, decimal price, string model, string brandName)
        {

            return new Laptop(deviceName, price, model, brandName);
        }

        public Smartphone MakeSmartPhone(string deviceName, decimal price, string model, string brandName)
        {

            return new Smartphone(deviceName, price, model, brandName);
        }
    }


}
