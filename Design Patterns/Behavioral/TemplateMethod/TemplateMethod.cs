using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.TemplateMethod
{
    public class TemplateMethodPatternApp
    {
        // Some restaurant
        public TemplateMethodPatternApp()
        {

            Grill grillOrder_1 = new KutumbariGrill();
            grillOrder_1.MakeGrill();
        }

    }

    abstract class Grill
    {
        public Grill()
        { 

        }

        public void MakeGrill()
        {
            BuyChicken();
            PrepareChicken();

            if (MoreSpice())
            {
                UseMoreSpice();
            }
            if (LessSpice())
            {
                UseLessSpice();
            }

            if (SmallerPieces())
            {
                CutIntoSmallerPieces();
            }


            AddOil();

            Cook();
        }


        private void BuyChicken()
        {
            Console.WriteLine("Getting a chicken");
        }


        private void PrepareChicken()
        {
            Console.WriteLine("Preparing the chicken");
        }

        // Hooks

        virtual protected bool MoreSpice() { return false; }
        virtual protected bool LessSpice() { return false; }
        virtual protected bool SmallerPieces() { return false; }

        // 
        abstract protected void UseMoreSpice();
        abstract protected void UseLessSpice();
        abstract protected void CutIntoSmallerPieces();

        private void AddOil()
        {
            Console.WriteLine("Adding oil");
        }

        private void Cook()
        {
            Console.WriteLine("Done");
        }


    }

    class KutumbariGrill : Grill
    {
        protected override bool SmallerPieces()
        {
            return true;
        }
        protected override void CutIntoSmallerPieces()
        {
            Console.WriteLine("Cutting into smaller pieces");
        }

        protected override void UseLessSpice()
        {
            //
        }

        protected override void UseMoreSpice()
        {
            // 
        }
    }
}
