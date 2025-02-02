
namespace Principios
{
    public class NotificationService
    {
        LogService logService = new LogService();


        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending Email to {email}: {message}");
             logService.LogNotification(message);

        }

        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
            logService.LogNotification(message);
        }
    }
}
