namespace Design_Patterns.Creational.AbstractFactory
{
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



}
