using WPFUI.Window;

namespace WPFUI
{
    public static class MessageBroker
    {
        public static void CreateNewMessage(System.Windows.Window window, string mEssage, string language = "en")
        {
            Message message = new Message(mEssage, language);
            message.Owner = window;
            message.ShowDialog();
        }

        public static bool CreateNewOptionMessage(System.Windows.Window window, string message, string language = "en")
        {
            OptionMessage optionMessage = new OptionMessage(message, language);
            optionMessage.Owner = window;
            bool result = (bool)optionMessage.ShowDialog();

            return result;
        }
    }
}
