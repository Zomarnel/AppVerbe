using AppVerbe.ViewModels;
using AppVerbe.Models;
using WPFUI.Window.CustomizationWindows;
using System.Windows.Controls;
using System.Windows;
using System.Linq;

namespace WPFUI.Window
{
    public partial class ModifyVerbWindow : System.Windows.Window
    {
        private AppSession _appSession;

        public ModifyVerbWindow(AppSession appSession)
        {
            InitializeComponent();

            _appSession = appSession;

            LanguageService.ChangeLanguage(this, _appSession.AppData.App_Language);

            DataContext = _appSession;
        }

        private void OnClick_ModifyVerb(object sender, RoutedEventArgs e)
        {
            Verbe verbe = ((FrameworkElement)sender).DataContext as Verbe;
            
            VerbModificationWindow verbModificationWindow = new VerbModificationWindow(verbe);

            verbModificationWindow.Owner = this.Owner;

            verbModificationWindow.ShowDialog();
        }
    }
}
