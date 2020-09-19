namespace Design_Patterns.Principles.Interfaces
{
    interface ICrew: IPlayer
    {
        void DoTask(ITask task);
        void FixEquipment(IEquipment equipment);
    }
}