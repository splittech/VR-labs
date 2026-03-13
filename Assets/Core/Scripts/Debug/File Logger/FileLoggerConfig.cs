using UnityEngine;

namespace Core.Debug
{
    [CreateAssetMenu(fileName = "FileLoggerConfig", menuName = "Configs/FileLoggerConfig", order = 3)]
    internal class FileLoggerConfig : ScriptableObject
    {
        [SerializeField] private string _fileName;

        public string FileName { get => FileName; }
    }
}
