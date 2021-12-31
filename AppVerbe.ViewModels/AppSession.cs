using AppVerbe.Models;
using System.ComponentModel;
using System.Collections.Generic;

namespace AppVerbe.ViewModels
{
    public class AppSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Verbe CurrentVerb { get; set; }
        public AppData AppData { get; set; }
        public AppSession()
        {
            AppData = new AppData("DefaultList", new List<Verbe>());
        }
    }
}
