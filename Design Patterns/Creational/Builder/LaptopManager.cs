namespace Design_Patterns.Creational.Builder
{
    // Director
    class LaptopManager: ProductManager<Laptop, LaptopBuilder>    {
        private LaptopBuilder _builder;
        public LaptopManager(LaptopBuilder builder)
        {
            _builder = builder;
        }

        
        public override void BuildProduct()
        {
            string name = "Asus";
            double price = 223.4;
            _builder.InitBuild(name, price);

            string batteryType = "L-ION";
            int batterySize = 2333;

            _builder.BuildBattery(batteryType, batterySize);

            _builder.BuildLaptopScreen(15.6, Screen.ScreenType.FullHD);

            _builder.BuildProcessor(8, "Intel", "i5 7700");

            _builder.BuildProductBrand("Asus");

            _builder.BuildSpecification();

        }

        public override Laptop GetProduct()
        {
            return _builder.GetProduct();
        }

        public override void SetBuilder(LaptopBuilder builder)
        {
            _builder = builder;
        }
    }
}
