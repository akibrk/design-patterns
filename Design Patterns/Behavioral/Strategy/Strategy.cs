using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.Strategy
{
    public class StrategyPatternApp
    {
        public StrategyPatternApp()
        {
            var person = new Adult("Zark", "Mymensingh");
            var child = new Teenager("Arno", "Fulpur");

            //person.Introduce();
            //child.Introduce();

            Console.WriteLine("Person trying to drive: " + person.TryToDrive());

            Console.WriteLine("Teenager trying to drive: " + child.TryToDrive());


        }
    }

    interface IDriverLicense
    {
        public string Drive();
    }

    class ValidLicense : IDriverLicense
    {
        public string Drive()
        {
            return "I can drive, where do you wanna go?";
        }
    }

    class InvalidLicense : IDriverLicense
    {
        public string Drive()
        {
            return "I cannot drive, I have no license";
        }
    }


    class Person
    {
        protected readonly string name;
        protected readonly string location;

        public IDriverLicense license;

        public Person(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        public void Walk()
        {
            Console.WriteLine($"{name} is walking");
        }

        public void Talk()
        {
            Console.WriteLine($"{name} is talking");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hellow, my name is {name}, I am from {location}");
        }

        public void UpdateDriverLicense(IDriverLicense license)
        {
            this.license = license;
        }

        public string TryToDrive()
        {
            return this.license.Drive();
        }

    }

    class Adult : Person
    {
        public Adult(string name, string location)
            : base(name, location)
        {
            this.UpdateDriverLicense(new ValidLicense());
        }
    }

    class Teenager : Person
    {
        public Teenager(string name, string location)
            : base(name, location)
        {
            this.UpdateDriverLicense(new InvalidLicense());
        }

        new public void Introduce()
        {
            Console.WriteLine($"Sup, name is {name}, I am from {location}");
        }
    }



}
