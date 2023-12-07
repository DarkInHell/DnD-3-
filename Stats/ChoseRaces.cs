using DnD.ClassesBin;
using DnD.RacesBin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using static DnD.RacesBin.RacesLog;

namespace DnD
{
    public class ChoseRaces : INotifyPropertyChanged
    {
        private List<string> classes;
        private List<string> races;
        private string selectedClass;
        private string selectedRace;

        public List<string> Classes
        {
            get { return classes; }
            set { classes = value; OnPropertyChanged(); }
        }

        public List<string> Races
        {
            get { return races; }
            set { races = value; OnPropertyChanged(); }
        }

        public string SelectedRace
        {
            get { return selectedRace; }
            set { selectedRace = value; OnPropertyChanged(); }
        }

        public string SelectedClass
        {
            get { return selectedClass; }
            set { selectedClass = value; OnPropertyChanged(); }
        }

        public ChoseRaces()
        {
            ClassStats[] classes = new ClassStats[] { new Warrior(), new Rogue() };
            Classes = new List<string>();
            for (int i = 0; i < classes.Length; i++)
            {
                Classes.Add(classes[i].ClassName);
            }

            RaceStats[] races = new RaceStats[] { new Human(), new Elf() };
            Races = new List<string>();
            for (int j = 0; j < races.Length; j++)
            {
                Races.Add(races[j].NameRace);
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
