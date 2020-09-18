namespace Design_Patterns.Principles.Interfaces
{
    interface IImposter
    {
        void Kill(ICrew crew);
        void Sabotage(IEquipment equipment);
    }
}