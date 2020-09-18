namespace Design_Patterns.Principles
{
    interface IPlayer:IEntity
    {
        bool Alive { get; set; }
        void MoveX(decimal XValue);
        void MoveY(decimal YValue);

        void Report();
        void Vote(IPlayer player);

        new string ToString();
        new string GetType();
    }
}