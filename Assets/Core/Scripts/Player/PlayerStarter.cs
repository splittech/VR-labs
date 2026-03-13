using VContainer.Unity;

namespace Core.Player
{
    public class PlayerStarter : IStartable, ITickable
    {
        public readonly PlayerSprint _playerSprint;

        public PlayerStarter(PlayerSprint playerSprint)
        {
            _playerSprint = playerSprint;
        }

        public void Start()
        {
            UnityEngine.Debug.Log("PlayerStarter started");
            UnityEngine.Debug.Log($"PlayerSprint {_playerSprint} initialized");
        }

        public void Tick()
        {
            _playerSprint.Update();
        }
    }
}
