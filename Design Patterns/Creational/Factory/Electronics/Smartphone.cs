namespace Design_Patterns.Creational.Factory
{
    class Smartphone : Electronic
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
