namespace Core.Debug
{
    public class EmptyLogger : BaseLogger
    {
        public override void Log(LogLevel logLevel, string message)
        {
            // Empty
        }
    }
}
