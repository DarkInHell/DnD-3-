using DnD.ClassesBin;
using DnD.RacesBin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using static DnD.RacesBin.RacesLog;
using static DnD.AllVariable;
using System.Windows;

namespace DnD
{
    public class ChoseRaces : INotifyPropertyChanged
    {
        
        private List<string> listClass;
        private List<string> listRace;
        private List<string> listAlignment;
        private string selectedClass;
        private string selectedRace;
        private string selectedAlignment;

        public List<string> ListClass
        {
            get { return listClass; }
            set { listClass = value; OnPropertyChanged(); }
        }

        public List<string> ListRace
        {
            get { return listRace; }
            set { listRace = value; OnPropertyChanged(); }
        }
        public List<string> ListAlignment
        {
            get { return listAlignment; }
            set { listAlignment = value; OnPropertyChanged(); }
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
        public string SelectedAlignment
        {
            get { return selectedAlignment; }
            set { selectedAlignment = value; OnPropertyChanged(); }
        }

        public ChoseRaces()
        {
            ListClass = new List<string>();
            Classes.ToList().ForEach(s => ListClass.Add(s.ClassName));

            ListRace = new List<string>();
            Races.ToList().ForEach(s => ListRace.Add(s.RaceName));

            ListAlignment = new List<string>();
            Alignments.ToList().ForEach(ListAlignment.Add);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
