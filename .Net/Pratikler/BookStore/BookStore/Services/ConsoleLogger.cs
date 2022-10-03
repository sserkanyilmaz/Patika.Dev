namespace WebApi.Services{
    public class ConsoleLogger : ILoggerService
    {
        public void Write(string message)
        {
            System.Console.WriteLine("[ConsoleLogger] - "+message);
        }
    }
}