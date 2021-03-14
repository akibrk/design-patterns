using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural.Decorator
{
    class DecoratorPatternApp
    {
        public DecoratorPatternApp()
        {
            var pizzaWithCheeseSauce = new TomatoSauce(new MozCheese(new Pizza()));
            var pizzaWithCheese = new MozCheese(new Pizza());

            Console.WriteLine("Description: " + pizzaWithCheeseSauce.GetDescirption());
            Console.WriteLine("Price:  " + pizzaWithCheeseSauce.GetPrice());
            Console.WriteLine("------------------");
            Console.WriteLine("Description: " + pizzaWithCheese.GetDescirption());
            Console.WriteLine("Price: " + pizzaWithCheese.GetPrice());

        }
    }

    interface IPizza
    {
        public string GetDescirption();
        public double GetPrice();
    }

    class Pizza : IPizza
    {
        private readonly double _basePrice;
        private readonly string _baseDescription;

        public Pizza()
        {
            _basePrice = 150.0;
            _baseDescription = "Dough";

            Console.WriteLine("Creating Pizza Base");
        }
        virtual public string GetDescirption()
        {
            return _baseDescription;
        }

        virtual public double GetPrice()
        {
            return _basePrice;
        }
    }

    abstract class ToppingDecorator: IPizza
    {
        protected readonly IPizza _pizza;
        protected virtual string ToppingName { get; set; }
        protected virtual double ToppingPrice { get; set; }

        public ToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        virtual public string GetDescirption()
        {
            return _pizza.GetDescirption();
        }

        virtual public double GetPrice()
        {
            return _pizza.GetPrice();
        }
    }

    class MozCheese : ToppingDecorator
    {
        public MozCheese(IPizza pizza)
            : base(pizza)
        {
            Console.WriteLine("Adding Mozzarella");
            ToppingName = "Mozzarella";
            ToppingPrice = 50.00;
        }

        override public string GetDescirption()
        {
            return _pizza.GetDescirption() + ", " +ToppingName;
        }

        public override double GetPrice()
        {
            return base.GetPrice() + ToppingPrice;
        }
    }

    class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza pizza)
            : base(pizza)
        {
            Console.WriteLine("Adding Sauce");
            ToppingName = "Tomato Sauce";
            ToppingPrice = 10.00;
        }

        override public string GetDescirption()
        {
            return _pizza.GetDescirption() + ", " + ToppingName;
        }

        public override double GetPrice()
        {
            return base.GetPrice() + ToppingPrice;
        }
    }


}
