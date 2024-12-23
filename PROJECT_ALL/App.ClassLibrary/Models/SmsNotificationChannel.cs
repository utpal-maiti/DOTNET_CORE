using App_ClassLibrary.Contracts;

namespace App_ClassLibrary
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}
