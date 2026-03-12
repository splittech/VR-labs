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

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<DebugTablet>();
            builder.RegisterInstance(_fpsText).Keyed(DebugTablet.TextType.FPS);
            builder.RegisterInstance(_logText).Keyed(DebugTablet.TextType.Log);
        }
    }
}
