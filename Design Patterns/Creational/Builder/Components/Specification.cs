using System;

namespace Design_Patterns.Creational.Builder
{
    class Specification
    {
        private readonly IProduct _product;
        public Specification(IProduct product)
        {
            _product = product;
        }

        public string Summary
        {
            get
            {
                return $"{_product.Name} | {_product.Price}";
            }   
        }

        public string Name { get; set; }
        public string Model { get; set; }
        public UInt16 ModelYear { get; set; }
        public Proccessor Proccessor { get; set; }

    }
}
