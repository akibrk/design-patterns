using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Principles
{
    class InterfaceSegregation
    {

    }

    // Bad Interface
    interface IISBadEntity
    {
        string Id { get; }
        string Name { get; set; }
        decimal PosX { get; set; }
        decimal PosY { get; set; }

        bool Alive { get; set; }
        void MoveX(decimal XValue);
        void MoveY(decimal YValue);

        void Report();
    }


    // Good Interface

    // Look at the interfaces folder

}
