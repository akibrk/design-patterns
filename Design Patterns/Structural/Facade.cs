using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural
{
    /// <summary>
    /// Represent a subsystem
    /// </summary>
    class Facade
    {
        private readonly Store _store = new Store();
        private readonly ReturnPolicy _returnPolicy = new ReturnPolicy();

        // Check eligibility before sending the product
        public bool CanReturnProduct(Product product)
        {
            if (_store.AcceptsReturn)
            {
                if (_returnPolicy.MeetsReturnPolicy(product)) return true;
            }
            return false;
        }

        // Just send the product for fixing
        public Product FixProduct(Product product)
        {
            if (!CanReturnProduct(product))
            {
                return product;
            }
            _store.AcceptReturnedProduct(product);
            _store.FixReturnedProduct();
            return _store.ReturnFixedProduct();
        }
        /*Main 
         * 
         * Product laptop = new Product("Asus Vivobook")
            {
                BrokenParts = true,
                WaterDamaged = true
            };

            Facade AsusServiceCenter = new Facade();

            if (AsusServiceCenter.CanReturnProduct(laptop))
            {
                laptop = AsusServiceCenter.FixProduct(laptop);
            }

            if (laptop.Repaired)
            {
                Println("Laptop was repaired");
            }
            else
            {
                Println("Sorry, could not repair the laptop");
            }
         
         */
    }

    class Product
    {

        public bool BrokenParts { get; set; } = false;
        public bool WaterDamaged { get; set; } = false;
        public bool BrokenOnDelivery { get; set; } = false;
        public bool Repaired { get; set; } = false;

        public readonly string Name;

        public Product(string name)
        {
            Name = name;
        }
    }

    class Store
    {
        private Product _product;
        public bool AcceptsReturn { get; set; } = true;
        public void AcceptReturnedProduct(Product product) 
        {
            _product = product;
        }

        public void FixReturnedProduct()
        {
            _product.BrokenParts = false;
            _product.BrokenOnDelivery = false;
            _product.Repaired = true;
        }

        public Product ReturnFixedProduct()
        {
            return _product;
        }

    }

    class ReturnPolicy
    {
        public bool MeetsReturnPolicy(Product product)
        {
            if (product.WaterDamaged) return false;
            return true ; 
        }
    }
}
