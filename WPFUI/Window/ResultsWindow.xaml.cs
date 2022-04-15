using System.Windows;
using System.Collections.Generic;
using AppVerbe.Models;
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

            ResultsLabel.Content = LanguageService.Translate("Final Results: ", language) + _finalResults.ResultsStringFormat;

            DataContext = _finalResults;
        }
    }
}
