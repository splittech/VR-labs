using System;
using UnityEngine;

namespace Core.Game
{
    public class GameConfig : ScriptableObject
    {
        [Flags]
        public enum LoggerOptionType
        {
            Tablet = 1,
            File = 2
        }

        [SerializeField] private LoggerOptionType _loggerOption;

        public LoggerOptionType LoggerOption { get => _loggerOption; }
    }
}
