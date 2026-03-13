using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace Core
{
    internal class FileLogger : BaseLogger
    {
        public readonly string FullPath;

        private readonly FileLoggerConfig _settings;

        public FileLogger(FileLoggerConfig settings)
        {
            _settings = settings;

            FullPath = Path.Combine(Application.persistentDataPath, _settings.FileName);

            ResetFile();
        }

        private void ResetFile()
        {
            File.WriteAllText(FullPath, "");
        }

        public override void Log(LogLevel logLevel, string message)
        {
            string fullMessage = $"{GetLogLevelString(logLevel)} {DateTime.Now}: {message}";

            using StreamWriter writer = new(FullPath, true, Encoding.UTF8);
                writer.WriteLine(fullMessage);
        }
    }
}
