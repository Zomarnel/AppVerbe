using AppVerbe.ViewModels;
using AppVerbe.Models;

namespace WPFUI.Window
{

    public partial class DeleteVerbWindow : System.Windows.Window
    {
        private AppSession _appSession = new AppSession();

        public DeleteVerbWindow(AppSession appSession)
        {
            InitializeComponent();

            _appSession = appSession;

            DataContext = _appSession;
        }
    }
}
