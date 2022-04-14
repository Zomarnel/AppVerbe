using AppVerbe.ViewModels;
using AppVerbe.Models;
using System.Windows;
using System.Linq;

namespace WPFUI.Window
{

    public partial class DeleteVerbWindow : System.Windows.Window
    {
        private AppSession _appSession;

        public DeleteVerbWindow(AppSession appSession)
        {
            InitializeComponent();

            _appSession = appSession;

            _appSession.CheckedVerbes = _appSession.AppData.ConvertVerbesToChecked();

            LanguageService.ChangeLanguage(this, _appSession.AppData.App_Language);

            DataContext = _appSession;
        }

        private void OnClick_DeleteSelectedVerb(object sender, RoutedEventArgs e)
        {
            if(!_appSession.CheckedVerbes.Any(cv => cv.IsChecked))
            {
                MessageBroker.CreateNewMessage(this, "Bru_Select_Atleast_One", _appSession.AppData.App_Language);
            }else
            {
                if (MessageBroker.CreateNewOptionMessage(this, "Are_U_Sure?"))
                {
                    foreach (CheckedVerbe checkedVerbe in _appSession.CheckedVerbes.Where(cv => cv.IsChecked))
                    {
                        _appSession.AppData.Verbes.Remove(checkedVerbe.Verbe);
                    }

                    _appSession.CheckedVerbes.RemoveAll(cv => cv.IsChecked);

                    DataGrid.ItemsSource = null;

                    DataGrid.ItemsSource = _appSession.CheckedVerbes;
                }
            }
        }
    }
}
