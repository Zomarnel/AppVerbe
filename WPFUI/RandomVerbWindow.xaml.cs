using System.Windows;
using System.Windows.Input;
using AppVerbe.Models;

namespace WPFUI
{
    public partial class RandomVerbWindow : Window
    {
        private Verbe _verbe; 
        public RandomVerbWindow(Verbe verbe)
        {
            InitializeComponent();

            _verbe = verbe;

            DataContext = _verbe;
        }
        private void MoveToTheNextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                switch (((FrameworkElement)sender).Name)
                {
                    case "PPS":
                        DPS.Focus();
                        break;
                    case "DPS":
                        TPS.Focus();
                        break;
                    case "TPS":
                        PPP.Focus();
                        break;
                    case "PPP":
                        DPP.Focus();
                        break;
                    case "DPP":
                        TPP.Focus();
                        break;
                }
            }
        }
    }
}
