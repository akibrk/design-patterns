using System;
using Design_Patterns.Principles.Interfaces;

namespace Design_Patterns.Principles.Characters
{
    class Imposter : IImposter
    {
        private readonly IPlayer Player;
        public string Name { get => Player.Name; set => Player.Name = value; }
        public bool Alive { get => Player.Alive; set => Player.Alive = value; }
        public string Id { get => Player.Id; }
        public decimal PosX { get => Player.PosX; set => Player.PosX = value; }
        public decimal PosY { get => Player.PosY; set => Player.PosY = value; }

        public Imposter(IPlayer player)
        {
            Player = player;
        }

        // Kills a crew member
        public void Kill(ICrew crew)
        {
            // Kicked players cannot sabotage
            if (!Player.Alive)
            {
                return;
            }
            // Otherwise console log event
            Console.WriteLine($"{Player.Name} killed {crew.Name}");
            crew.Alive = false;
        }

        // Sabotage an equipment
        public void Sabotage(IEquipment equipment)
        {
            Console.WriteLine($"{Player.Name} Sabotaged Equipment: {equipment.Name}");
            equipment.IsSubotaged = true;
        }

        new public string GetType()
        {
            return "Imposter";
        }

        new public string ToString()
        {
            return Player.ToString();
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
