using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Builder
{
    class Battery
    {
        public int BatterySize { get; set; }
        public string BatteryType { get; set; }

        public Battery(string type, int size)
        {
            BatterySize = size;
            BatteryType = type;
        }
    }
}
