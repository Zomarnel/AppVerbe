using System.Collections.Generic;
using System.ComponentModel;

namespace AppVerbe.Models
{
    public class Verbe : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public string Temps { get; set; }
        public List<ConjuguatedForm> ConjuguatedForms { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Verbe(string name, string temps, List<ConjuguatedForm> conjuguatedForms) 
        {
            Name = name;
            Temps = temps;
            ConjuguatedForms = conjuguatedForms;
        }
    }
}
