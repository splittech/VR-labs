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

        private int _maxDebugMessages = 10;
        private Queue<string> _debugMessages;

        public DebugTablet(
            [Key(TextType.FPS)] TMP_Text fpsTextComponent,
            [Key(TextType.Log)] TMP_Text logTextComponent)
        {
            _fpsTextComponent = fpsTextComponent;
            _logTextComponent = logTextComponent;

            _debugMessages = new Queue<string>();
            _logTextComponent.text = "";
        }

        public void Tick()
        {
            UpdateFPS();
        }

        public void AddDebugMessage(string debugMessage)
        {
            if (_debugMessages.Count == _maxDebugMessages)
                _debugMessages.Dequeue();

            _debugMessages.Enqueue(debugMessage);

            _logTextComponent.text = "";
            foreach (var message in _debugMessages)
                _logTextComponent.text += $"{message}\n";
        }

        private void UpdateFPS()
        {
            float fps = Mathf.Round(1.0f / Time.deltaTime);
            _fpsTextComponent.text = fps.ToString();
            AddDebugMessage(fps.ToString());
        }
    }
}
