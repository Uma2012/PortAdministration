using System;
using System.Collections.Generic;
using System.Text;

namespace PortAdministration.Models
{
    class Ship
    {
        public string Id { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public int HaltingDays { set { HaltingDays = 6; } }
    }
}
