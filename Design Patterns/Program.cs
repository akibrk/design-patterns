using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Behavioral.Iterator;

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
            var list = new ConcreteAggregate();
            list.PushBack(12);
            list.PushBack(11);

            var it = list.CreateIterator();
            Println(it.Current());
            Println(it.Next());
            //Println(it.Next());


            Println(it.IsDone());
        }
    }

}
