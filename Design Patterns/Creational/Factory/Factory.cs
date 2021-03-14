using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Factory
{
    /// <summary>
    /// No need to deal with instantiation 
    /// When to use it:
    /// 1. When you don't know ahead of time what subclasses you are gonna use
    /// 2. To centralize class selection code
    /// 3. To encapsulate object creation
    /// 4. When you don't want the user to 
    /// </summary>
    public class FactoryPatternApp
    {
        /// <summary>
        /// Factory
        /// </summary>
        
        private readonly FurnitureFactory _furnitureFactory;
        private readonly ElectronicsFactory _electronicsFactory;
        public FactoryPatternApp()
        {
            _furnitureFactory = new FurnitureFactory();
            _electronicsFactory = new ElectronicsFactory();

            Product p = CreateRandomProduct(24);
        }

        public Product CreateRandomProduct(int randomValue)
        {
            if(randomValue % 3 == 0)
            {
                return _electronicsFactory.MakeLaptop("Vivobooks", 450, "Vivobook S15", "Asus");

            }else if (randomValue % 5 == 0)
            {
                return _electronicsFactory.MakeSmartPhone("Xiaomi Mi 6", 3000, "Xiomi mi 6", "Xiomi");
            }
            else if(randomValue % 2 == 0)
            {
                return _furnitureFactory.CreateChair("Your Chair", 0.00M);

            }
            else
            {
                return _furnitureFactory.CreateTable("Your Table", 100);
            }
        }

    }

    /// <summary>
    /// Sub Factory
    /// </summary>
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

    /// <summary>
    /// Sub Factory
    /// </summary>
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
