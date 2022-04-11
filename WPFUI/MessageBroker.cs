using WPFUI.Window;

namespace WPFUI
{
    public static class MessageBroker
    {
        public static void CreateNewMessage(System.Windows.Window window, string mEssage)
        {
            Message message = new Message(mEssage);
            message.Owner = window;
            message.ShowDialog();
        }

        public static bool CreateNewOptionMessage(System.Windows.Window window, string message)
        {
            OptionMessage optionMessage = new OptionMessage(message);
            optionMessage.Owner = window;
            bool result = (bool)optionMessage.ShowDialog();

            return result;
        }
    }
}
