using System;

namespace Design_Patterns.Creational.Builder
{
    class Proccessor
    {
        public UInt16 Generation { get; set; }
        public string Menufecturer { get; set; }
        public string Model { get; set; }
        public Proccessor(UInt16 generation, string menufecturer, string model)
        {
            Generation = generation;
            Menufecturer = menufecturer;
            Model = model;
        }
        new public string ToString()
        {
            return $"CPU: {Model} - {Generation} - {Menufecturer} ";
        }
    }
}
