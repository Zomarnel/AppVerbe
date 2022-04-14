using System;
using System.Windows;

namespace WPFUI
{
    public partial class Message : System.Windows.Window
    {
        public Message(string message, string language)
        {
            InitializeComponent();


            LanguageService.ChangeLanguage(this, language);

            var translater = new ResourceDictionary();
            translater.Source =
                new Uri("..\\Resources/Resources." + $"{language}" + ".xaml",
                        UriKind.RelativeOrAbsolute);

            MessageLabel.Content = translater[message];
            ButtonClose.Focus();
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
