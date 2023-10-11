using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DnD.Races;

namespace DnD.Races
{
    public class Gnome
    {
        public Gnome() 
        {
            DnD.Races.RaceVM Gnome = new RaceVM
            {
                Speed = 25,
                Height = 3.5,
                Width = 40,
                StrengthRaceStats = 0,
                AgilityRaceStats = 0,
                VitalityRaceStats = 0,
                IntellectRaceStats = 1,
                WitRaceStats = 0,
                CharismaRaceStats = 0,
                Lang = "Общий, Гномий"    
            };

        }
    }
}
