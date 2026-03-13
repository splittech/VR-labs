using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "FileLoggerConfig", menuName = "Configs/FileLoggerConfig", order = 2)]
    internal class FileLoggerConfig : ScriptableObject
    {
        [SerializeField] private string _fileName;

        public string FileName { get => FileName; }
    }
}
