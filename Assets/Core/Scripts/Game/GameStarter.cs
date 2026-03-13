using Core.Debug;
using VContainer.Unity;

namespace Core.Game
{
    public class GameStarter : IStartable, ITickable
    {
        private readonly DebugTablet _debugTablet;
        private readonly FPSCalculator _fpsCalculator;

        public GameStarter(DebugTablet debugTablet, FPSCalculator fpsCalculator)
        {
            _debugTablet = debugTablet;
            _fpsCalculator = fpsCalculator;
        }

        public void Start()
        {
            UnityEngine.Debug.Log("GameStarter started");
            UnityEngine.Debug.Log($"DebugTablet {_debugTablet} initialized");
        }

        public void Tick()
        {
            _fpsCalculator.Update();
        }
    }
}
