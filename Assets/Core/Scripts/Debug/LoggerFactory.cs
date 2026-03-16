using Core.Game;
using System.Collections.Generic;
using VContainer;

namespace Core.Debug
{
    public class LoggerFactory
    {
        private readonly IObjectResolver _container;

        public LoggerFactory(IObjectResolver container)
        {
            _container = container;
        }

        public BaseLogger CreateLogger(GameConfig.LoggerOptionType loggerOption)
        {
            List<BaseLogger> loggers = new();

            if (loggerOption.HasFlag(GameConfig.LoggerOptionType.Tablet))
            {
                loggers.Add(_container.Resolve<TabletLogger>());
            }
            if (loggerOption.HasFlag(GameConfig.LoggerOptionType.File))
            {
                loggers.Add(_container.Resolve<FileLogger>());
            }

            if (loggers.Count == 0)
                return new EmptyLogger();

            if (loggers.Count == 1)
                return loggers[0];

            return new CompositeLogger(loggers);
        }
    }
}
