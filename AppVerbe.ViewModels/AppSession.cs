using AppVerbe.Models;
using AppVerbe.Services;
using System.ComponentModel;

namespace AppVerbe.ViewModels
{
    public class AppSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Verbe CurrentVerb { get; set; }
        public AppData AppData { get; set; }
        public AppSession()
        {
            AppData = SavingService.LoadListOrCreateNewOne("FirstList");
        }
    }
}
