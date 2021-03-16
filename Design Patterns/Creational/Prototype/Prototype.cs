using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Prototype
{
    public class PrototypePatternApp
    {
        public PrototypePatternApp()
        {
            var sheep1 = new Sheep("Baah");
            var sheep2 = sheep1.Clone();


            // Clone
            Console.WriteLine(sheep2.ToString());

            // Modify Clone
            sheep2.Name = "Meeh";

            // Original
            Console.WriteLine(sheep1.ToString());

            // Modified Clone
            // Does not effect the original
            Console.WriteLine(sheep2.ToString());


        }
    }



    interface IAnimal: ICloneable
    {
    }
    class Animal : IAnimal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if(value.Length > 100)
                {
                    throw new Exception("Name is too long");
                }

                this.name = value;
            }
        }
        virtual public Animal Clone()
        {
            return (Animal)this.MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name; 
        }
    }

    class Sheep : Animal
    {
        public Sheep(string name)
            : base(name)
        {
            Console.WriteLine("Creating a sheep");
           
        }

        override public Animal Clone()
        {
            return (Sheep)base.Clone();
        }
    }

}
