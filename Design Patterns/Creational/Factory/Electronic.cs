using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Factory
{
    class Electronic: Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Electronic()
        {
            Category = "Electronic";
        }
    }
}
