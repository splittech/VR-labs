using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using VContainer;
using VContainer.Unity;

namespace Core.Player
{
    public class PlayerScope : LifetimeScope
    {
        [Header("Configs")]
        [SerializeField] private PlayerConfig _playerConfig;

        [Header("Components")]
        [SerializeField] private DynamicMoveProvider _dynamicMoveProvider;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_playerConfig);

            builder.RegisterInstance(_dynamicMoveProvider);

            builder.Register<PlayerSprint>(Lifetime.Singleton);

            builder.RegisterEntryPoint<PlayerStarter>();
        }
    }
}
