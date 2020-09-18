namespace Design_Patterns.Principles
{
    interface IEntity
    {
        string Id { get; set; }
        string Name { get; set; }
        decimal PosX { get; set; }
        decimal PosY { get; set; }
    }
}