namespace Design_Patterns.Principles.Interfaces
{
    interface ICrew
    {
        bool IsAlive { get; set; }
        string Name { get; }

        void DoTask(ITask task);
        void FixEquipment(IEquipment equipment);
    }
}