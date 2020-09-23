using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Builder
{
    interface IProductManager<ProductType, BuilderType>
    {
        abstract ProductType GetProduct();
        public void BuildProduct();
        public void SetBuilder(BuilderType builder);
    }
}
