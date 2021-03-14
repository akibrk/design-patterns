namespace Design_Patterns.Creational.Factory
{
    class Laptop : Electronic
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
