using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
        }

        private void OpenWindow_OnClick(object sender, RoutedEventArgs e)
        {
            switch(((FrameworkElement)sender as Button).Name)
            {
                case "AddVerb":
                    AddVerbWindow addVerbWindow = new AddVerbWindow(_appSession);

                    addVerbWindow.Owner = this.Owner;
                    addVerbWindow.DataContext = _appSession;
                    addVerbWindow.ShowDialog();
                    break;

                case "DeleteVerb":
                    DeleteVerbWindow deletedVerbWindow = new DeleteVerbWindow(_appSession);

                    deletedVerbWindow.Owner = this.Owner;
                    deletedVerbWindow.DataContext = _appSession;
                    deletedVerbWindow.ShowDialog();
                    break;

            }
        }
    }
}
