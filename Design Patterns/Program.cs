using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Behavioral.Facade;

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
            var _manager = new AdmissionManager();
            _manager.AdmitStudent("Akib", 10, 500);


        }
    }

}
