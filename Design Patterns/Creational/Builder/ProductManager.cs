using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Builder
{
    abstract class ProductManager<ProductType, BuilderType>: IProductManager<ProductType, BuilderType>
    {

        abstract public void BuildProduct();

        abstract public ProductType GetProduct();

        abstract public void SetBuilder(BuilderType builder);
      
    }
}
