using System.Windows;
using System.Collections.Generic;
using AppVerbe.Models;
using System;

namespace WPFUI
{
    public partial class ResultsWindow : System.Windows.Window
    {
        private VerbeResults _finalResults = new VerbeResults();

        public ResultsWindow(VerbeResults finalResults, string language)
        {
            InitializeComponent();

            _finalResults = finalResults;

            LanguageService.ChangeLanguage(this, language);

            ResourceDictionary translater = new ResourceDictionary();

            translater.Source = new Uri("..\\Resources/Resources." + $"{language}" + ".xaml", UriKind.Relative);

            ResultsLabel.Content = translater["Final Results: "] + _finalResults.ResultsStringFormat;

            DataContext = _finalResults;
        }
    }
}
