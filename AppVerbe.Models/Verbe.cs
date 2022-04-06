using System.Collections.Generic;
using System.ComponentModel;

namespace AppVerbe.Models
{
    public class Verbe : INotifyPropertyChanged
    {
        public string Name { get; init; }

        public string Temps { get; init; }
        public List<ConjuguatedForm> ConjuguatedForms { get; init; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Verbe(string name, string temps, List<ConjuguatedForm> conjuguatedForms) 
        {
            Name = name;
            Temps = temps;
            ConjuguatedForms = conjuguatedForms;
        }
    }
}
