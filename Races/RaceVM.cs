using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Races
{
    internal class RaceVM
    {
        public int Speed { get; set; }
        public int Width { get; set; }
        public double Height { get; set; }
        public int StrengthRaceStats { get; set; }
        public int AgilityRaceStats { get; set; }
        public int VitalityRaceStats { get; set; }
        public int IntellectRaceStats { get; set; }
        public int WitRaceStats { get; set; }
        public int CharismaRaceStats { get; set; }
        public string Lang { get; set; }
        public RaceVM() 
        { 
            
        }

    }
}
