namespace Principios.SOLID
{
    public class LogService
    {
        public void LogNotification(string message)
        {
            Console.WriteLine($"Logging notificacion: {message}");
        }
    }
}
