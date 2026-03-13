using System;
using UnityEngine;

namespace Core.Debug
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

        public void Update()
        {
            _framesInInterval++;
            _intervalTime += Time.deltaTime;

            if (_intervalTime > _debugTabletConfig.CalculateFPSInterval)
            {
                CalculateFPS();
                ResetCounters();
            }
        }

        private void CalculateFPS()
        {
            float fps = _framesInInterval / _intervalTime;
            OnFPSCalculated.Invoke(fps);
        }

        private void ResetCounters()
        {
            _framesInInterval = 0;
            _intervalTime = 0f;
        }
    }
}