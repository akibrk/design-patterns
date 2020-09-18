using System;

namespace Design_Patterns.Principles
{
    class Imposter : IImposter
    {
        private readonly IPlayer Player;
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
            crew.IsAlive = false;
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
    }
}
