using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Builder
{
    abstract class ProductBuilder<ProductType> : IProductBuilder<ProductType>
    {
        public ProductType _product;
        abstract public ProductType GetProduct();
    }
}
