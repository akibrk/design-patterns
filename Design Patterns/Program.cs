using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Principles;
using Design_Patterns.Principles.Characters;

namespace Design_Patterns
{
    class Program
    {
        static public void Println<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            LiskovSubstitution.PrintEntityName(new Player("Akib"));
        }
    }

}
