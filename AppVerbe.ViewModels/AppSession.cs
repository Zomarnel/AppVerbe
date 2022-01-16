using AppVerbe.Models;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace AppVerbe.ViewModels
{
    public class AppSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AppData AppData { get; set; }
        public AppSession()
        {
            AppData = new AppData("DefaultList", new List<Verbe>());
        }
        public Verbe ReturnRandomVerbe()
        {
            Random random = new Random();

            if(AppData.Verbes.Any())
            {
                return AppData.Verbes[random.Next(AppData.Verbes.Count)];
            }

            return null;
        }
    }
}
