using System;
using UnityEngine;

namespace Core
{
    public class FPSCalculator
    {
        private const float CalculateFPSInterval = 1f; // In seconds

        private int _totalFrames = 0;
        private float _totalTime = 0f;

        public event Action<float> OnFPSCalculated;

        public FPSCalculator()
        {

        }

        public void Tick()
        {
            _totalFrames++;
            _totalTime += Time.deltaTime;

            if (_totalTime > CalculateFPSInterval)
                CalculateFPS();
        }

        private void CalculateFPS()
        {
            float fps = _totalFrames / _totalTime;

            _totalFrames = 0;
            _totalTime = 0f;

            OnFPSCalculated.Invoke(fps);
        }
    }
}