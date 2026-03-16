using Core.Game;
using UnityEngine;

namespace Core.Debug
{
    [CreateAssetMenu(fileName = "FileLoggerConfig", menuName = "Configs/FileLoggerConfig", order = 3)]
    public class FileLoggerConfig : ScriptableObject
    {
        [Header("Parameters")]
        [SerializeField] private string _fileName;

        [Header("Logger")]
        [SerializeField] private GameConfig.LoggerOptionType _loggerOption;

        public string FileName { get => _fileName; }
        public GameConfig.LoggerOptionType LoggerOption { get => _loggerOption; }
    }
}

