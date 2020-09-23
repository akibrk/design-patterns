namespace Design_Patterns.Creational.Builder
{
    class Electronics : Product
    {
        public string SubCategory { get; set; }
        public Specification _specificaiton;
        public Brand Brand { get; set; }
        public Electronics()
        {
            Category = "Electronics";
        }
    }
}
