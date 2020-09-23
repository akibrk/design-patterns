using System;

namespace Design_Patterns.Creational.Builder
{
    interface IBrand 
    {
        string Name { get; set; }
        UInt16 Rating { get; set; }
    }
}
