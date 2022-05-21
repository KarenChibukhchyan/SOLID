using static System.Console;

namespace _05_DIP
{
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            WriteLine("In Email::SendMessage method... Sending message...");
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            WriteLine("In SMS::SendMessage method... Sending message...");
        }
    }
}