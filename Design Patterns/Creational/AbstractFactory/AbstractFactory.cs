using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational
{
    // Basically an Interface
    class AbstractFactoryPatternApp
    {
        public AbstractFactoryPatternApp()
        {

        }
    }


    // Example

    abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    abstract class Electronics: Product
    {
        new public string Category
        {
            get
            {
                return "Electronics";
            }
            set
            {
                throw new NotImplementedException("Cannot set catgeory name");
            }
        }
        public string SubCategory { get; set; }
        public string Brand { get; set; }
        public string Specifications { get; set; }
        public string Model { get; set; }

        new public string ToString()
        {
            string result = $"{Name} | Model: {Model} | {Brand} | {SubCategory}";

            return result;
        }
    }

 
    class Laptop : Electronics
    {
        public Laptop(string laptopName, decimal price, string model, string brand)
        {
            SubCategory = "Laptop";
            Name = laptopName;
            Price = price;
            Brand = brand;
            Model = model;
        }
    }

    class Smartphone: Electronics
    {
        public Smartphone(string smartphoneName, decimal price, string model, string brand)
        {
            SubCategory = "Smartphone";
            Name = smartphoneName;
            Price = price;
            Brand = brand;
            Model = model;
        }
    }

    abstract class Furniture: Product
    {
        new public string Category { 
            get
            {
                return "Furniture";
            }
            set
            {
                throw new NotImplementedException("Cannot set catgeory name");
            }
        }
        public string SubCategory { get; set; }
        
        new public string ToString()
        {
            return $"{Name} | {SubCategory} | {Category}";
        }
    }

    class Chair: Furniture
    {
        public Chair(string productName, decimal productPrice)
        {
            SubCategory = "Chair";
            Name = productName;
            Price = productPrice;
        }
    }

    class Table : Furniture
    {
        public Table(string productName, decimal productPrice)
        {
            SubCategory = "Table";
            Name = productName;
            Price = productPrice;
        }
    }



}
