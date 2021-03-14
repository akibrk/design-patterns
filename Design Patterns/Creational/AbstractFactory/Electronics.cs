using System;

namespace Design_Patterns.Creational.AbstractFactory
{
    abstract class Electronics : Product
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



}
