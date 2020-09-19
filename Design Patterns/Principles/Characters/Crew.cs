using System;
using Design_Patterns.Principles.Interfaces;

namespace Design_Patterns.Principles.Characters
{
    class Crew : ICrew 
    {
        private readonly IPlayer Player;
        public string Name { get => Player.Name; set => Player.Name = value; }
        public bool Alive { get => Player.Alive; set => Player.Alive = value; }
        public string Id { get => Player.Id;}
        public decimal PosX { get => Player.PosX; set => Player.PosX = value; }
        public decimal PosY { get => Player.PosY; set => Player.PosY = value; }


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

        public void FixEquipment(IEquipment equipment)
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
            if (!task.IsCompleted)
            {
                task.IsCompleted = true;
                Console.WriteLine($"{Name} is doing {task.Name}");
            }
        }

        public void MoveX(decimal XValue)
        {
            Player.MoveX(XValue);
        }

        public void MoveY(decimal YValue)
        {
            Player.MoveY(YValue);
        }

        public void Report()
        {
            Player.Report();
        }

        public void Vote(IPlayer player)
        {
            Player.Vote(player);
        }
    }
}
