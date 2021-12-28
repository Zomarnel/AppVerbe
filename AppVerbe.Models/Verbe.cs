using System.Collections.Generic;
using System.ComponentModel;

namespace AppVerbe.Models
{
    public class Verbe : INotifyPropertyChanged
    {
        public string Name { get; }
        public IEnumerable<ConjuguatedForm> ConjuguatedForms { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        public Verbe(string name, IEnumerable<ConjuguatedForm> conjuguatedForms) 
        {
            Name = name;
            ConjuguatedForms = conjuguatedForms;
        }
    }
}
