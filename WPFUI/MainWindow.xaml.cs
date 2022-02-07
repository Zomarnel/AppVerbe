using System.Windows;
using System;
using Microsoft.Win32;
using System.Linq;
using AppVerbe.ViewModels;
using AppVerbe.Services;
using AppVerbe.Models;

namespace WPFUI
{
    public partial class MainWindow : Window
    {
        private const string SAVE_LIST_FILE_EXTENSION = "omar";
        private AppSession _appSession;
        public MainWindow()
        {
            InitializeComponent();

            _appSession = new AppSession();

            DataContext = _appSession;

        }
        private void SaveGame_OnClick(object sender, RoutedEventArgs e)
        {
            SaveGame();
        }
        private void LoadGame_OnClick(object sender, RoutedEventArgs e)
        {
            LoadGame();
        }
        private void AddNewVerb_OnClick(object sender, RoutedEventArgs e)
        {
            AddVerbWindow addVerbWindow = new AddVerbWindow(_appSession);

            addVerbWindow.Owner = this;
            addVerbWindow.DataContext = _appSession;
            addVerbWindow.ShowDialog();
        }
        private void RandomVerb_OnClick(object sender, RoutedEventArgs e)
        {
            Verbe verbe = _appSession.ReturnRandomVerbe();

            if(verbe != null)
            {
                RandomVerbWindow randomVerbWindow = new RandomVerbWindow(_appSession.AppData.Verbes);

                randomVerbWindow.Owner = this;
                randomVerbWindow.ShowDialog();
            }
        }
        
        private void SaveGame()
        {
            SaveFileDialog saveFileDialog =
                new SaveFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Filter = $"Save games (*.{SAVE_LIST_FILE_EXTENSION})|*.{SAVE_LIST_FILE_EXTENSION}"
                };

            if(saveFileDialog.ShowDialog() == true)
            {
                SavingService.SaveList(_appSession.AppData, saveFileDialog.FileName);
            }
        }
        private void LoadGame()
        {
            OpenFileDialog openFileDialog =
                new OpenFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Filter = $"Save games (*.{SAVE_LIST_FILE_EXTENSION})|*.{SAVE_LIST_FILE_EXTENSION}"
                };

            if (openFileDialog.ShowDialog() == true)
            {
                _appSession.AppData = SavingService.LoadListOrCreateNewOne(openFileDialog.FileName);
            }
        }
    }
}
