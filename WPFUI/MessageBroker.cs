using System.Windows;

namespace WPFUI
{
    public static class MessageBroker
    {
        private static Message _message;
        public static void CreateNewMessage(Window window, string message)
        {
            _message = new Message(message);
            _message.Owner = window;
            _message.ShowDialog();
        }
    }
}
