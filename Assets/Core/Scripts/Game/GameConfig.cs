using UnityEngine;

namespace Core.Game
{
    internal class GameConfig : ScriptableObject
    {
        public enum LoggerOption
        {
            None,
            All,
            Tablet,
            File
        }

        [SerializeField]
        private LoggerOption _loggerOption;
    }
}
