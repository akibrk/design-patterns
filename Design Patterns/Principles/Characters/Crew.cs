using System;
using Design_Patterns.Principles.Interfaces;

namespace Design_Patterns.Principles.Characters
{
    class Crew : ICrew
    {
        private readonly IPlayer Player;
        public string Name
        {
            get { return Player.Name; }
        }

        public bool IsAlive
        {
            get
            {
                return Player.Alive;
            }
            set
            {
                Player.Alive = value;
            }
        }

        public Crew(IPlayer player)
        {
            Player = player;
        }

        public void DoTask(Task task)
        {
            if (!task.IsCompleted)
            {
                task.IsCompleted = true;
                Console.WriteLine($"{Name} is doing {task.Name}");
            }
        }

        public void FixEquipment(Equipment equipment)
        {
            if (equipment.IsSubotaged)
            {
                equipment.IsSubotaged = false;
                Console.WriteLine($"{Name} fixed {equipment.Name}");
            }
        }

        new public string GetType()
        {
            return "Crew";
        }

        new public string ToString()
        {
            return Player.ToString();
        }

        public void DoTask(ITask task)
        {
            throw new NotImplementedException();
        }

        public void FixEquipment(IEquipment equipment)
        {
            throw new NotImplementedException();
        }
    }
}
