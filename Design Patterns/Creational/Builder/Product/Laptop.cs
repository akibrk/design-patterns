
namespace Design_Patterns.Creational.Builder
{
    class Laptop : Electronics
    {
        public Screen Screen { get; set; }
        public Battery Battery { get; set; }
        public Proccessor Proccessor { get; set; }

        public Laptop(string name, double price)
        {
            Name = name;
            Price = price;
        }

        new public string ToString()
        {
            var result = $"{Name} - Price: {Price} | {Brand.Name} - {Screen.ToString()} | {Battery.ToString()} | {Proccessor.ToString()}";

            return result;
        }
    }
}
