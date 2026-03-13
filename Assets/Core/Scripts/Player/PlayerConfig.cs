using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace Core.Player
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 1)]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private float _walkSpeed = 3f;
        [SerializeField] private float _sprintSpeed = 6f;

        [SerializeField]
        [Tooltip("Input data that will be used to perform sprinting.")]
        private XRInputButtonReader _sprintInput = new XRInputButtonReader("Sprint");

        public float SprintSpeed { get => _sprintSpeed; }
        public float WalkSpeed { get => _walkSpeed; }
        public XRInputButtonReader SprintInput { get => _sprintInput; }
    }
}
