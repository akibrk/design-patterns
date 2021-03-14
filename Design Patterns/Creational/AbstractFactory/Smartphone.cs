namespace Design_Patterns.Creational.AbstractFactory
{
    class Smartphone : Electronics
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



}
