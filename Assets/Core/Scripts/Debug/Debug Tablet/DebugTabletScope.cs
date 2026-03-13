using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core
{
    internal class DebugTabletScope : LifetimeScope
    {
        [Header("Components")]
        [SerializeField] private TMP_Text _fpsText;
        [SerializeField] private TMP_Text _logText;

        [Header("Configs")]
        [SerializeField] private DebugTabletConfig _debugTabletConfig;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_debugTabletConfig);

            builder.RegisterInstance(_fpsText).Keyed(DebugTablet.TextType.FPS);
            builder.RegisterInstance(_logText).Keyed(DebugTablet.TextType.Log);

            builder.Register<FPSCalculator>(Lifetime.Singleton);

            builder.RegisterEntryPoint<DebugTablet>();
        }
    }
}
