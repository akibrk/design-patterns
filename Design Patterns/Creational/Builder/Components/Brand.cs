using System;

namespace Design_Patterns.Creational.Builder
{
    class Brand : IBrand
    {
        public string Name { get; set; }
        public UInt16 Rating { get; set; }

        public Brand(string name, UInt16 rating)
        {
            Name = name;
            Rating = rating;
        }

        public void IncreaseRating()
        {
            if(Rating < 10)
                Rating++;
        }

    }
}
