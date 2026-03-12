using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Core
{
    public class NewMonoBehaviourScript : MonoBehaviour
    {
        private XRSocketInteractor _socket;
        private XRGrabInteractable _interactable;

        public XRSocketInteractor Socket { get => _socket; }
        public XRGrabInteractable Interactable { get => _interactable; }

        public void Construct(XRSocketInteractor socket, XRGrabInteractable interactable)
        {
            _socket = socket;
            _interactable = interactable;
        }

        private void Start()
        {
            GameObject go = new GameObject("Mock");

            _socket = go.AddComponent<XRSocketInteractor>();
            _interactable = go.AddComponent<XRGrabInteractable>();
        }
    }
}
