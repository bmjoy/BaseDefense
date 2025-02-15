using BaseDefense.BroadcastMessages;
using BaseDefense.BroadcastMessages.Messages;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BaseDefense {

    public class JoystickController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

        [SerializeField]
        private RectTransform joystick;

        [SerializeField]
        private RectTransform circle;

        private Vector2 m_joystickPosition;


        public Vector3 GetInput () {
            var vector2 = m_joystickPosition;
            var move = new Vector3(vector2.x, 0, vector2.y);

            return move;
        }


        public void OnBeginDrag (PointerEventData eventData) {
            circle.gameObject.SetActive(true);
            circle.position = eventData.position;
        }


        public void OnDrag (PointerEventData eventData) {
            var size = circle.rect.size;
            m_joystickPosition = circle.InverseTransformPoint(eventData.position);
            m_joystickPosition = Vector2.ClampMagnitude(m_joystickPosition, size.x / 2);
            joystick.localPosition = m_joystickPosition;
            m_joystickPosition = m_joystickPosition.normalized * (m_joystickPosition.magnitude / (size.x / 2));
        }


        public void OnEndDrag (PointerEventData eventData) {
            circle.gameObject.SetActive(false);
            joystick.localPosition = Vector2.zero;
            m_joystickPosition = Vector2.zero;
        }


        private void Start () {
            circle.gameObject.SetActive(false);
            m_joystickPosition = Vector2.zero;
        }


        private void Awake () {
            Messenger.SubscribeTo<RestartMessage>(EnableJoystick);
            Messenger.SubscribeTo<DeathPlayerMessage>(DisableJoystick);
        }


        private void OnDestroy () {
            Messenger.UnsubscribeFrom<RestartMessage>(EnableJoystick);
            Messenger.UnsubscribeFrom<DeathPlayerMessage>(DisableJoystick);
        }


        private void EnableJoystick () => enabled = true;


        private void DisableJoystick () {
            enabled = false;
            circle.gameObject.SetActive(false);
            m_joystickPosition = Vector3.zero;
        }

    }

}