using System;

namespace Core
{
    internal abstract class BaseLogger
    {
        public enum LogLevel
        {
            Info,
            Warn,
            Error
        }

        public abstract void Log(LogLevel logLevel, string message);

        protected string GetLogLevelString(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Info => "[INFO]",
                LogLevel.Warn => "[WARN]",
                LogLevel.Error => "[ERROR]",
                _ => throw new NotImplementedException()
            };
        }
    }
}
