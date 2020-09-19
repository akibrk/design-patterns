namespace Design_Patterns.Principles.Interfaces
{
    interface IEntity
    {
        string Id { get; }
        string Name { get; set; }
        decimal PosX { get; set; }
        decimal PosY { get; set; }
    }
}