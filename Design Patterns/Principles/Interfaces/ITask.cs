namespace Design_Patterns.Principles
{
    interface ITask:IEntity
    {
        bool IsCompleted { get; set; }
    }
}