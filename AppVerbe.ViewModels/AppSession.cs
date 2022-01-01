using AppVerbe.Models;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace AppVerbe.ViewModels
{
    public class AppSession : INotifyPropertyChanged
    {
        private Random random = new Random();

        public event PropertyChangedEventHandler PropertyChanged;
        public Verbe CurrentVerb { get; set; }
        public AppData AppData { get; set; }
        public bool IsCurrentVerbNull { get; set; } = false;
        public AppSession()
        {
            AppData = new AppData("DefaultList", new List<Verbe>());
        }
        public void ChooseRandomVerbFromList()
        {
            if(AppData.Verbes.Count == 0)
            {
                CurrentVerb = null;
                return;
            }

            int randomNumber = random.Next(AppData.Verbes.Count);

            CurrentVerb = AppData.Verbes[randomNumber];
            
        }
    }
}
