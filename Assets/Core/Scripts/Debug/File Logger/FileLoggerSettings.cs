using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "FileLoggerSettings", menuName = "Settings", order = 1)]
    internal class FileLoggerSettings : ScriptableObject
    {
        [SerializeField]
        public readonly string FileName;
    }
}
