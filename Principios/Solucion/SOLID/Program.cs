using Principios.SOLID;

internal class Program
{
    private static void Main(string[] args)
    {
        NotificationService notificationService = new NotificationService();
        notificationService.SendEmail("20240076@itla.edu.do", "Hola, este es un mensaje de prueba");
        notificationService.SendSMS("829-660-4658", "Hola, este es OTRO mensaje de prueba");
    }
}
