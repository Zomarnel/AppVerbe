using System.Windows;
using System;
using Microsoft.Win32;
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
            SetVisibilityToLabelsAndTextBoxes();

            _appSession.ChooseRandomVerbFromList();

            SetVisibilityToLabelsAndTextBoxes();
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

        private void SetVisibilityToLabelsAndTextBoxes()
        {
            if(_appSession.CurrentVerb != null)
            {
                lbName.Visibility = Visibility.Visible;
                tbName.Visibility = Visibility.Visible;

                foreach (ConjuguatedForm conjuguatedForm in _appSession.CurrentVerb.ConjuguatedForms)
                {
                    switch(conjuguatedForm.Personne)
                    {
                        case 1:
                            lbPPS.Visibility = Visibility.Visible;
                            tbPPS.Visibility = Visibility.Visible;
                            break;
                        case 2:
                            lbDPS.Visibility = Visibility.Visible;
                            tbDPS.Visibility = Visibility.Visible;
                            break;
                        case 3:
                            lbTPS.Visibility = Visibility.Visible;
                            tbTPS.Visibility = Visibility.Visible;
                            break;
                        case 4:
                            lbPPP.Visibility = Visibility.Visible;
                            tbPPP.Visibility = Visibility.Visible;
                            break;
                        case 5:
                            lbDPP.Visibility = Visibility.Visible;
                            tbDPP.Visibility = Visibility.Visible;
                            break;
                        case 6:
                            lbTPP.Visibility = Visibility.Visible;
                            tbTPP.Visibility = Visibility.Visible;
                            break;
                    }
                }
            }else
            {
                lbName.Visibility = Visibility.Hidden;
                tbName.Visibility = Visibility.Hidden;

                lbPPS.Visibility = Visibility.Hidden;
                tbPPS.Visibility = Visibility.Hidden;

                lbDPS.Visibility = Visibility.Hidden;
                tbDPS.Visibility = Visibility.Hidden;

                lbTPS.Visibility = Visibility.Hidden;
                tbTPS.Visibility = Visibility.Hidden;

                lbPPP.Visibility = Visibility.Hidden;
                tbPPP.Visibility = Visibility.Hidden;

                lbDPP.Visibility = Visibility.Hidden;
                tbDPP.Visibility = Visibility.Hidden;

                lbTPP.Visibility = Visibility.Hidden;
                tbTPP.Visibility = Visibility.Hidden;
            }
        }
    }
}
