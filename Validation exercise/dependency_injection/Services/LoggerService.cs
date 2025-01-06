namespace dependency_injection.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly Guid _id;

        public LoggerService()
        {
            _id = Guid.NewGuid();
        }

        public string Log(string message)
        {
            return $"[{_id}] {message} logged at {DateTime.UtcNow}";
        }
    }
}
