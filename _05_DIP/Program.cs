using System.Collections.Generic;
using static System.Console;

namespace _05_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification emailNotification = new Notification(new Email());
            Notification smsNotification = new Notification(new SMS());
            emailNotification.DoNotify();
            smsNotification.DoNotify();

        }
    }
}