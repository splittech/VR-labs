using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "DebugTabletConfig", menuName = "Configs/DebugTabletConfig", order = 1)]
    public class DebugTabletConfig : ScriptableObject
    {
        [SerializeField] private int _maxLogMessages;
        [SerializeField] private float _calculateFPSInterval;

        public float MaxLogMessages { get => _maxLogMessages; }
        public float CalculateFPSInterval { get => _calculateFPSInterval; }
    }
}
