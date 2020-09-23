using System;

namespace Design_Patterns.Creational.Builder
{
    class LaptopBuilder : ProductBuilder<Laptop>
    {
        // Product Spec sheet
        public void BuildSpecification()
        {
            _product._specificaiton = new Specification(_product);
        }
        // Product Brand
        public void BuildProductBrand(string brandName)
        {
            // Rating is 0 initially
            _product.Brand = new Brand(brandName, 0); ;
        }

        public void InitBuild(string name, double price)
        {
            _product =  new Laptop(name, price);
        }

        public void BuildLaptopScreen(double screenSize, Screen.ScreenType screenType)
        {
            _product.Screen =  new Screen(screenSize, screenType);
        }

        public void BuildProcessor(UInt16 gen, string menufecturer, string model)
        {
            _product.Proccessor =  new Proccessor(gen, menufecturer, model);
        }

        public void BuildBattery(string batteryType, int batterySize)
        {
            _product.Battery = new Battery(batteryType, batterySize);
        }

        public override Laptop GetProduct()
        {
            return _product;
        }

    }
}
