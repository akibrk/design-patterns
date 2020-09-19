using System;
using System.Collections.Generic;
using System.Text;
using Design_Patterns.Principles.Characters;

namespace Design_Patterns.Principles
{
    // What to do and what not to dow
    class SingleReponsibility
    {
        public static BadEntity CreateCrew(string crewName)
        {
            var crew = new BadEntity(crewName, "crew");
            return crew;
        }

        public static BadEntity CreateImposter(string imposterName)
        {
            var imposter = new BadEntity(imposterName, "imposter");
            return imposter;
        }

        public static Imposter GCreateImposter(string imposterName)
        {
            var imposter = new Imposter(new Player(imposterName));
            return imposter;
        }
    }


    // What not to do
    class BadEntity
    {
        private static long IdSeed = 0;
        public readonly string Id;
        public string EType;
        public string Name { get; set; }

        public BadEntity(string entityName, string entityType)
        {
            Id = (++IdSeed).ToString();
            Name = entityName;
            EType = entityType;
        }
        public void MoveX(int XValue)
        {
            Console.WriteLine($"{Name} is moving {XValue} in X-Axis");
        }
        public void MoveY(int YValue)
        {
            Console.WriteLine($"{Name} is moving {YValue} in Y-Axis");
        }
        public void Report()
        {
            Console.WriteLine($"Deadbody found");
        }

        public void Kill(long PlayerId)
        {
            Console.WriteLine($"{Name} Killed {PlayerId}");
        }

        public void Sabotage(long EquipmentId)
        {
            Console.WriteLine($"{Name} Sabotaged Equipment: {EquipmentId}");
        }
        public void DoTask(long TaskId)
        {
            Console.WriteLine($"{Name} is doing task: {TaskId}");
        }

        public void Vote(long PlayerId)
        {
            Console.WriteLine($"{Name} just voted: {PlayerId}");
        }

        new public string GetType()
        {
            return EType;
        }

        new public string ToString()
        {
            return Name;
        }
    }
}
