using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            set { selectedClass = value; OnPropertyChanged();}
        }

        public ChoseRaces()
        {
            Classes = new List<string>
            {
                "Воин",
                "Маг",
                "Плут"
            };
            Races = new List<string>
            {
                "Человек",
                "Эльф",
                "Дварф"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
