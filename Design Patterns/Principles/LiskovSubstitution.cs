using Design_Patterns.Principles.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Principles
{
    class LiskovSubstitution
    {
        // An instance of a class should be replaceable by an instance of its derived class 

        // Basically We should be able to replace any Entity instance with any of the deried class members

        // For example
        // In Program.cs main()
        // Write
        // LiskovSubstitution.PrintEntityName(new Player("Akib"));

        static public void PrintEntityName(Entity entity)
        {
            Console.WriteLine(entity.Name);
        }


    }
}
