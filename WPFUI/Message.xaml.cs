using System.Windows;

namespace WPFUI
{
    public partial class Message : Window
    {
        public Message(string message)
        {
            InitializeComponent();

            MessageLabel.Content = message;
            ButtonClose.Focus();
        }
        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
