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

        private PositionOnCanvas Position_TopRightTextBlock = new PositionOnCanvas();
        private PositionOnCanvas Position_TopLeftTextBlock = new PositionOnCanvas();
        private PositionOnCanvas Position_BottomRightTextBlock = new PositionOnCanvas();
        private PositionOnCanvas Position_BottomLeftTextBlock = new PositionOnCanvas();

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
                RandomVerbWindow randomVerbWindow = new RandomVerbWindow(_appSession.AppData.Verbes);

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
                        Canvas.SetRight(element, Canvas.GetRight(MainButton) - 100);
                        Canvas.SetBottom(element, Canvas.GetBottom(MainButton));
                        break;

                    case "BottomRightButton":
                        Canvas.SetRight(element, Canvas.GetRight(MainButton) - 100);
                        Canvas.SetBottom(element, Canvas.GetBottom(MainButton) - 100);
                        break;

                    case "BottomLeftButton":
                        Canvas.SetRight(element, Canvas.GetRight(MainButton));
                        Canvas.SetBottom(element, Canvas.GetBottom(MainButton) - 100);
                        break;
                }
            }
        }

        private void ResizeTextBlocks()
        {

            double width = TopRightButton.ActualHeight;

            //Top right buttons and textblocks
            Canvas.SetRight(TopRightTextBlock, Canvas.GetRight(TopRightButton) + (TopRightButton.ActualWidth/2 - TopRightTextBlock.ActualWidth) / 2);
            Canvas.SetBottom(TopRightTextBlock, Canvas.GetBottom(TopRightButton) + (TopRightButton.ActualHeight - TopRightTextBlock.ActualHeight) / 2);

            //Top left buttons and textblocks
            Canvas.SetRight(TopLeftTextBlock, Canvas.GetRight(MainButton) + (MainButton.ActualWidth / 2 - TopLeftTextBlock.ActualWidth) / 2);
            Canvas.SetBottom(TopLeftTextBlock, Canvas.GetBottom(MainButton) + (MainButton.ActualHeight - TopLeftTextBlock.ActualHeight) / 2);

            //Bottom right buttons and textblocks
            Canvas.SetRight(BottomRightTextBlock, Canvas.GetRight(BottomRightButton) + (BottomRightButton.ActualWidth / 2 - BottomRightTextBlock.ActualWidth) / 2);
            Canvas.SetBottom(BottomRightTextBlock, Canvas.GetBottom(BottomRightButton) + (BottomRightButton.ActualHeight - BottomRightTextBlock.ActualHeight) / 2);

            //Bottom left buttons and textblocks
            Canvas.SetRight(BottomLeftTextBlock, Canvas.GetRight(BottomLeftButton) + (BottomLeftButton.ActualWidth / 2 - BottomLeftTextBlock.ActualWidth) / 2);
            Canvas.SetBottom(BottomLeftTextBlock, Canvas.GetBottom(BottomLeftButton) + (BottomLeftButton.ActualHeight/2 - BottomLeftTextBlock.ActualHeight) / 2);

        }
        #endregion
    }
}
