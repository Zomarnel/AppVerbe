using System.Windows;
using System;
using System.Windows.Controls;
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

        private double WIDTH_HEIGHT = 150; 

        public MainWindow()
        {
            InitializeComponent();

            _appSession = new AppSession();

            DataContext = _appSession;
        }

        #region Events
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
                RandomVerbWindow randomVerbWindow = new RandomVerbWindow(_appSession.AppData.CloneVerbs());

                randomVerbWindow.Owner = this;
                randomVerbWindow.ShowDialog();
                
            }
        }

        private void MainCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ResizeButtons();

            ResizeTextBlocks();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            ResizeButtons();

            ResizeTextBlocks();
        }

        #endregion Events

        #region Functions
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

        private void ResizeButtons()
        {
            foreach (UIElement element in MainCanvas.Children)
            {
                if (element is not Button)
                {
                    continue;
                }

                switch (((Button)element).Name)
                {
                    case "TopRightButton":
                        Canvas.SetRight(element, Canvas.GetRight(MainButton) - WIDTH_HEIGHT);
                        Canvas.SetBottom(element, Canvas.GetBottom(MainButton));
                        break;

                    case "BottomRightButton":
                        Canvas.SetRight(element, Canvas.GetRight(MainButton) - WIDTH_HEIGHT);
                        Canvas.SetBottom(element, Canvas.GetBottom(MainButton) - WIDTH_HEIGHT);
                        break;

                    case "BottomLeftButton":
                        Canvas.SetRight(element, Canvas.GetRight(MainButton));
                        Canvas.SetBottom(element, Canvas.GetBottom(MainButton) - WIDTH_HEIGHT);
                        break;
                }
            }
        }

        private void ResizeTextBlocks()
        {

            //Top right buttons and textblocks
            Canvas.SetRight(TopRightTextBlock, Canvas.GetRight(TopRightButton) + ((WIDTH_HEIGHT - TopRightTextBlock.ActualWidth) / 2) + 10);
            Canvas.SetBottom(TopRightTextBlock, Canvas.GetBottom(TopRightButton) + ((WIDTH_HEIGHT - TopRightTextBlock.ActualHeight) / 2) - 8);

            //Top left buttons and textblocks
            Canvas.SetRight(TopLeftTextBlock, Canvas.GetRight(MainButton) + ((WIDTH_HEIGHT - TopLeftTextBlock.ActualWidth) / 2) - 10);
            Canvas.SetBottom(TopLeftTextBlock, Canvas.GetBottom(MainButton) + ((WIDTH_HEIGHT - TopLeftTextBlock.ActualHeight) / 2) - 8);

            //Bottom right buttons and textblocks
            Canvas.SetRight(BottomRightTextBlock, Canvas.GetRight(BottomRightButton) + ((WIDTH_HEIGHT - BottomRightTextBlock.ActualWidth) / 2) + 10);
            Canvas.SetBottom(BottomRightTextBlock, Canvas.GetBottom(BottomRightButton) + ((WIDTH_HEIGHT - BottomRightTextBlock.ActualHeight) / 2) + 8);

            //Bottom left buttons and textblocks
            Canvas.SetRight(BottomLeftTextBlock, Canvas.GetRight(BottomLeftButton) + ((WIDTH_HEIGHT - BottomLeftTextBlock.ActualWidth) / 2) - 10);
            Canvas.SetBottom(BottomLeftTextBlock, Canvas.GetBottom(BottomLeftButton) + ((WIDTH_HEIGHT - BottomLeftTextBlock.ActualHeight) / 2) + 8);

        }
        #endregion
    }
}
