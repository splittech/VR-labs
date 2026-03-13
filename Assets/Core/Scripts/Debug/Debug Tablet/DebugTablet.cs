using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core
{
    internal class DebugTablet : ITickable
    {
        public enum TextType
        {
            FPS,
            Log
        }

        private readonly TMP_Text _fpsTextComponent;
        private readonly TMP_Text _logTextComponent;
        private readonly FPSCalculator _fpsCalculator;
        private readonly DebugTabletConfig _debugTabletConfig;

        private Queue<string> _logMessages;

        public DebugTablet(
            [Key(TextType.FPS)] TMP_Text fpsTextComponent,
            [Key(TextType.Log)] TMP_Text logTextComponent,
            DebugTabletConfig debugTabletConfig,
            FPSCalculator fpsCalculator)
        {
            _fpsTextComponent = fpsTextComponent;
            _logTextComponent = logTextComponent;
            _fpsCalculator = fpsCalculator;
            _debugTabletConfig = debugTabletConfig;

            _logMessages = new Queue<string>();

            _fpsCalculator.OnFPSCalculated += OnFPSCalculated;

            ShowLogMessages(new Queue<string>());
        }

        public void Tick()
        {
            _fpsCalculator.Tick();
        }

        public void AddDebugMessage(string debugMessage)
        {
            if (_logMessages.Count == _debugTabletConfig.MaxLogMessages)
                _logMessages.Dequeue();

            _logMessages.Enqueue(debugMessage);

            ShowLogMessages(_logMessages);
        }

        private void ShowLogMessages(Queue<string> logMessages)
        {
            _logTextComponent.text = "";
            foreach (var message in logMessages)
                _logTextComponent.text += $"{message}\n";
        }
        private void OnFPSCalculated(float fps)
        {
            _fpsTextComponent.text = $"FPS: {Mathf.Round(fps)}";
            AddDebugMessage(Mathf.Round(fps).ToString());
        }
    }
}
