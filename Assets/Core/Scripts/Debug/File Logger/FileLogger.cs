using Core.Game;
using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace Core.Debug
{
    internal class FileLogger : BaseLogger
    {
        private readonly FileLoggerConfig _fileLoggerConfig;
        private readonly BaseLogger _logger;
        private readonly string _fullFilePath;

        public FileLogger(FileLoggerConfig fileLoggerConfig, LoggerFactory loggerFactory)
        {
            _fileLoggerConfig = fileLoggerConfig;

            // Unset the 'FileLogger' loger option for FileLogger (exclude self reference).
            GameConfig.LoggerOptionType loggerOptionWithoutFileLogger =
                _fileLoggerConfig.LoggerOption & ~GameConfig.LoggerOptionType.File;

            _logger = loggerFactory.CreateLogger(loggerOptionWithoutFileLogger);

            _fullFilePath = Path.Combine(Application.persistentDataPath, _fileLoggerConfig.FileName + ".txt");

            CreateFile();
        }

        private void CreateFile()
        {
            try
            {
                File.WriteAllText(_fullFilePath, "");
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, $"Failed to create log file: {e.Message}");
                return;
            }

            _logger.Log(LogLevel.Info, $"Log file created at path: {_fullFilePath}.");
            Log(LogLevel.Info, $"Log file created at path: {_fullFilePath}.");
        }

        public override void Log(LogLevel logLevel, string message)
        {
            string fullMessage = $"{GetLogLevelString(logLevel)} {DateTime.Now}: {message}";

            using StreamWriter writer = new(_fullFilePath, true, Encoding.UTF8);
                writer.WriteLine(fullMessage);
        }
    }
}
