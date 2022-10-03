namespace WebApi.Services{
    public class DBLogger : ILoggerService
    {
        public void Write(string message)
        {
            System.Console.WriteLine("[DBLogger] - "+message);
        }
    }
}