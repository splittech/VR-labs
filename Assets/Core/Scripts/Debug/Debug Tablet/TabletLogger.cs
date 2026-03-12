namespace Core
{
    internal class TabletLogger : BaseLogger
    {
        private readonly DebugTablet _debugTablet;

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
