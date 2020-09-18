using Design_Patterns.Principles.Interfaces;

namespace Design_Patterns.Principles.Characters
{
    class Task : Entity, ITask
    {
        private bool Completed;

        public bool IsCompleted
        {
            get { return Completed; }
            set { Completed = value; }
        }

        public Task(string taskName)
        {
            Name = taskName;
            Completed = false;
        }

        new public string GetType()
        {
            return "Task";
        }

        new public string ToString()
        {
            return Name;
        }
    }
}
