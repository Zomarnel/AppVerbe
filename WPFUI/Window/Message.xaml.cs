using System.Windows;

namespace WPFUI
{
    public partial class Message : System.Windows.Window
    {
        public Message(string message, string language)
        {
            InitializeComponent();

            LanguageService.ChangeLanguage(this, language);

            MessageLabel.Content = LanguageService.Translate(message, language);
            ButtonClose.Focus();
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
