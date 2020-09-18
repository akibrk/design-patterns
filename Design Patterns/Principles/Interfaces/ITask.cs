namespace Design_Patterns.Principles.Interfaces
{
    interface ITask:IEntity
    {
        bool IsCompleted { get; set; }
    }
}