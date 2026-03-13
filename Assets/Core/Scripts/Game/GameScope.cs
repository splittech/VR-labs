using Core.Debug;
using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core.Game
{
    public class GameScope : LifetimeScope
    {
        [Header("Configs")]
        [SerializeField] private DebugTabletConfig _debugTabletConfig;

        [Header("Components")]
        [SerializeField] private TMP_Text _debugTabletFPStext;
        [SerializeField] private TMP_Text _debugTabletLogText;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_debugTabletConfig);

            builder.RegisterInstance(_debugTabletFPStext).Keyed(DebugTablet.TextType.FPS);
            builder.RegisterInstance(_debugTabletLogText).Keyed(DebugTablet.TextType.Log);

            builder.Register<FPSCalculator>(Lifetime.Singleton);
            builder.Register<DebugTablet>(Lifetime.Singleton);
            builder.Register<TabletLogger>(Lifetime.Singleton);

            builder.RegisterEntryPoint<GameStarter>();
        }
    }
}
