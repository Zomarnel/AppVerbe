using System.ComponentModel;

namespace AppVerbe.Models
{
    public class CheckedVerbe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Verbe Verbe { get; init; }

        public bool IsChecked { get; set; }

        public CheckedVerbe(Verbe verbe)
        {
            Verbe = verbe;

        }
    }
}
