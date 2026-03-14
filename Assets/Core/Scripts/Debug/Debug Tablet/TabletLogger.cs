namespace Core.Debug
{
    public class TabletLogger : BaseLogger
    {

        public TabletLogger(DebugTablet debugTablet)
        {
            _debugTablet = debugTablet;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            string fullMessage = $"{GetLogLevelString(LogLevel.Info)} {message}";
            _debugTablet.AddDebugMessage(fullMessage);
        }
    }
}
