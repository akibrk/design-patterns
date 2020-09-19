namespace Design_Patterns.Principles.Interfaces
{
    interface IImposter : IPlayer
    {
        void Kill(ICrew crew);
        void Sabotage(IEquipment equipment);
    }
}