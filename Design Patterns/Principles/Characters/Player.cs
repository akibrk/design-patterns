using System;
using Design_Patterns.Principles.Interfaces;

namespace Design_Patterns.Principles.Characters
{
    class Player : Entity, IPlayer
    {
        public bool Alive { get; set; }
        public Player(string playerName)
        {
            Name = playerName;
            Alive = true;
        }

        // Vote for kicking
        public void Vote(Player player)
        {
            Console.WriteLine($"{Name} just voted against: {player.Name}");
        }

        // Move functions
        public void MoveX(decimal XValue)
        {
            Console.WriteLine($"{Name} is moving {XValue} in X-Axis");
            PosX += XValue;
        }
        public void MoveY(decimal YValue)
        {
            Console.WriteLine($"{Name} is moving {YValue} in Y-Axis");
            PosY += YValue;
        }

        // Report a dead crew member
        public void Report()
        {
            Console.WriteLine($"Deadbody found");
        }

        new public string GetType()
        {
            return "Player";
        }

        new public string ToString()
        {
            return Name;
        }

        public void Vote(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
