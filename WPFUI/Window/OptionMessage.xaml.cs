using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFUI.Window
{

    public partial class OptionMessage : System.Windows.Window
    {
        public OptionMessage(string message, string language)
        {
            InitializeComponent();

            LanguageService.ChangeLanguage(this, language);

            var translater = new ResourceDictionary();
            translater.Source =
                new Uri("..\\Resources/Resources." + $"{language}" + ".xaml",
                        UriKind.RelativeOrAbsolute);

            MessageLabel.Content = translater[message];
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
