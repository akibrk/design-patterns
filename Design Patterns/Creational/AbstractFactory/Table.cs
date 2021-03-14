namespace Design_Patterns.Creational.AbstractFactory
{
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
