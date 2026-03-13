using Core.Debug;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

namespace Core.Player
{
    public class PlayerSprint
    {
        private readonly PlayerConfig _playerConfig;
        private readonly DynamicMoveProvider _dynamicMoveProvider;
        private readonly TabletLogger _tabletLogger;

        private bool _isSprinting = false;

        public PlayerSprint(
            PlayerConfig playerConfig,
            DynamicMoveProvider dynamicMoveProvider,
            TabletLogger tabletLogger)
        {
            _playerConfig = playerConfig;
            _dynamicMoveProvider = dynamicMoveProvider;
            _tabletLogger = tabletLogger;

            _dynamicMoveProvider.moveSpeed = _playerConfig.WalkSpeed;
        }

        public void Update()
        {
            if (_playerConfig.SprintInput.ReadIsPerformed())
            {
                if (!_isSprinting)
                {
                    _isSprinting = true;
                    StartSprinting();
                }
            }
            else
            {
                if (_isSprinting)
                {
                    _isSprinting = false;
                    StopSprinting();
                }
            }
        }
        
        private void StartSprinting()
        {
            _dynamicMoveProvider.moveSpeed = _playerConfig.SprintSpeed;
            _tabletLogger.Log(BaseLogger.LogLevel.Info, $"Started sprinting with speed: {_playerConfig.SprintSpeed}");
        }

        private void StopSprinting()
        {
            _dynamicMoveProvider.moveSpeed = _playerConfig.WalkSpeed;
            _tabletLogger.Log(BaseLogger.LogLevel.Info, $"Started walking with speed: {_playerConfig.WalkSpeed}");
        }
    }
}


