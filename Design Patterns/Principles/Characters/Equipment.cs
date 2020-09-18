namespace Design_Patterns.Principles
{
    class Equipment : Entity, IEquipment
    {

        private bool Sabotaged;

        public bool IsSubotaged
        {
            get { return Sabotaged; }
            set { Sabotaged = value; }
        }


        public Equipment(string equipmentName)
        {
            Name = equipmentName;
            IsSubotaged = false;
        }

        new public string GetType()
        {
            return "Equipment";
        }

        new public string ToString()
        {
            return Name;
        }

    }
}
