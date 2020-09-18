namespace Design_Patterns.Principles
{
    interface ICrew
    {
        bool IsAlive { get; set; }
        string Name { get; }

        void DoTask(ITask task);
        void FixEquipment(IEquipment equipment);
        string GetType();
        string ToString();
    }
}