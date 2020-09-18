namespace Design_Patterns.Principles
{
    interface IImposter
    {
        string GetType();
        void Kill(ICrew crew);
        void Sabotage(IEquipment equipment);
        string ToString();
    }
}