using System.Windows;
using System.Windows.Controls;
using AppVerbe.ViewModels;

namespace WPFUI.Window
{
    public partial class CustomizeListMenu : System.Windows.Window
    {
        private AppSession _appSession;

        public CustomizeListMenu(AppSession appSession)
        {
            InitializeComponent();

            _appSession = appSession;

            LanguageService.ChangeLanguage(this, _appSession.AppData.App_Language);
        }

        private void OpenWindow_OnClick(object sender, RoutedEventArgs e)
        {
            switch(((FrameworkElement)sender as Button).Name)
            {
                case "AddVerb":
                    AddVerbWindow addVerbWindow = new AddVerbWindow(_appSession);

                    addVerbWindow.Owner = this.Owner;
                    addVerbWindow.ShowDialog();
                    break;

                case "DeleteVerb":
                    DeleteVerbWindow deletedVerbWindow = new DeleteVerbWindow(_appSession);

                    deletedVerbWindow.Owner = this.Owner;
                    deletedVerbWindow.ShowDialog();
                    break;
                case "ModifyVerb":
                    ModifyVerbWindow modifyVerbWindow = new ModifyVerbWindow(_appSession);

                    modifyVerbWindow.Owner = this.Owner;
                    modifyVerbWindow.ShowDialog();
                    break;

            }
        }
    }
}
