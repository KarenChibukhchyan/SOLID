namespace _05_DIP
{
    public class Notification
    {
        private IMessenger _iMessenger;

        public Notification(IMessenger pMessenger)
        {
            _iMessenger = pMessenger;
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }
}