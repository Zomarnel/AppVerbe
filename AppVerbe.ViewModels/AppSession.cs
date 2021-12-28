using AppVerbe.Models;
using System.ComponentModel;

namespace AppVerbe.ViewModels
{
    public class AppSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Verbe CurrentVerb { get; }
    }
}
