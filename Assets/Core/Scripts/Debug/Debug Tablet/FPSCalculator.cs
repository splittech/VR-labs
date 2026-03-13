using System;
using UnityEngine;

namespace Core
{
    public class FPSCalculator
    {
        private readonly DebugTabletConfig _debugTabletConfig;

        private int _framesInInterval = 0;
        private float _intervalTime = 0f;

        public event Action<float> OnFPSCalculated;

        public FPSCalculator(DebugTabletConfig debugTabletConfig)
        {
            _debugTabletConfig = debugTabletConfig;
        }

        public void Tick()
        {
            _framesInInterval++;
            _intervalTime += Time.deltaTime;

            if (_intervalTime > _debugTabletConfig.CalculateFPSInterval)
            {
                CalculateFPS();
                _framesInInterval = 0;
                _intervalTime = 0f;
            }
        }

        private void CalculateFPS()
        {
            float fps = _framesInInterval / _intervalTime;
            OnFPSCalculated.Invoke(fps);
        }
    }
}