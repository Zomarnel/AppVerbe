using System.Windows;
using AppVerbe.ViewModels;

namespace WPFUI
{
    public partial class MainWindow : Window
    {
        public AppSession _appSession;
        public MainWindow()
        {
            InitializeComponent();

            _appSession = new AppSession();
        }
    }
}
