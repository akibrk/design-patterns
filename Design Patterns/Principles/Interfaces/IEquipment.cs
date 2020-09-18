namespace Design_Patterns.Principles
{
    interface IEquipment:IEntity
    {
        bool IsSubotaged { get; set; }

        new string GetType();
        new string ToString();
    }
}