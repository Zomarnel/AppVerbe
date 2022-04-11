using System.Windows;
using System.Windows.Controls;

namespace WPFUI.Window
{

    public partial class OptionMessage : System.Windows.Window
    {
        public OptionMessage(string message)
        {
            InitializeComponent();

            MessageLabel.Content = message;
        }

        private void OnClick_ReturnBoolValue(object sender, RoutedEventArgs e)
        {
            switch(((FrameworkElement)sender as Button).Name)
            {
                case "YesButton":
                    DialogResult = true;
                    Close();
                    break;

                case "NoButton":
                    DialogResult = false;
                    Close();
                    break;
            }
        }
    }
}
