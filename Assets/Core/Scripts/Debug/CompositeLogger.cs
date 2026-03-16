using System.Collections.Generic;

namespace Core.Debug
{
    public class CompositeLogger : BaseLogger
    {
        private readonly List<BaseLogger> _loggers;

        public CompositeLogger(List<BaseLogger> loggers)
        {
            _loggers = loggers;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            foreach (var logger in _loggers)
                logger.Log(logLevel, message);
        }
    }
}
