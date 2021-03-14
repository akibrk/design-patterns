namespace Design_Patterns.Creational.Factory
{
    class Chair : Furniture
    {
        public Chair(string productName, decimal productPrice)
        {
            SubCategory = "Chair";
            Name = productName;
            Price = productPrice;
        }
    }



}
