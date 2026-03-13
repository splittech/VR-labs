using UnityEngine;

namespace Core.Debug
{
    [CreateAssetMenu(fileName = "DebugTabletConfig", menuName = "Configs/DebugTabletConfig", order = 2)]
    public class DebugTabletConfig : ScriptableObject
    {
        [SerializeField] private int _maxLogMessages;
        [SerializeField] private float _calculateFPSInterval;

        public float MaxLogMessages { get => _maxLogMessages; }
        public float CalculateFPSInterval { get => _calculateFPSInterval; }
    }
}
