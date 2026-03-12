using UnityEngine;

namespace Core
{
    internal class ProjectSettings : ScriptableObject
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
