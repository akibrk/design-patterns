using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Builder
{
    interface IProductBuilder<ProductType>
    {
        public ProductType GetProduct();
    }
}
