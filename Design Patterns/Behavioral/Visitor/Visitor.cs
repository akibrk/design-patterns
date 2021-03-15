using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.Visitor
{
    public class VisitorPatternApp
    {
        public VisitorPatternApp()
        {
            TaxAuditor auditor = new TaxAuditor();
            Furniture chair = new Furniture(100);
            Electronics phone = new Electronics(20000);

            chair.Accept(auditor);
            phone.Accept(auditor);

        }

    }


    interface IVisitor
    {
        public double Visit(Furniture visitable);
        public double Visit(Electronics visitable);

    }

    class TaxAuditor : IVisitor
    {
        public double Visit(Furniture visitable)
        {
            return visitable.Price * .10; 
        }

        public double Visit(Electronics visitable)
        {
            return visitable.Price * .20;
        }
    }


    interface IVisitable
    {
        public void Accept(IVisitor visitor);
    }

    class Product
    {
        private readonly double _price;

        public Product(double price)
        {
            this._price = price;
        }


        public double Price 
        {
            get
            {
                return _price;
            }
        }

    }

    class Furniture : Product, IVisitable
    {
        public Furniture(double price)
            : base(price)
        {

        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"Tax of {this.GetType().Name}:  {visitor.Visit(this)}");
        }
    }

    class Electronics : Product, IVisitable
    {
        public Electronics(double price)
            : base(price)
        {

        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"Tax of {this.GetType().Name}: {visitor.Visit(this)}");
        }



    }



}
