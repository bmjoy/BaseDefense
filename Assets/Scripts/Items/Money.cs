using System.Collections;
using BroadcastMessages;
using UnityEngine;

namespace BaseDefense.Items
{
    public class Money : Item
    {
        ///<summary>Время, необходимое для проигрывания анимации сброса предмета на базу</summary>
        ///<value>[0, infinity]</value>
        [Tooltip("Время, необходимое для проигрывания анимации сброса предмета на базу. [0, infinity]")]
        [SerializeField, Min(0)] float collectionTime = 3;

        void OnEnable() => Messenger.AddListener(MessageType.PUSH_UNUSED_ITEMS, Remove);
        void OnDisable() => Messenger.RemoveListener(MessageType.PUSH_UNUSED_ITEMS, Remove);

        public override void Destroy()
        {
            StartCoroutine(DestroyMoney());
        }

        public override void Drop(Vector3 force, Vector3 torque = default)
        {
            enabled = true;
            rb.AddForce(force, ForceMode.Impulse);
            rb.AddTorque(torque, ForceMode.Impulse);
        }

        IEnumerator DestroyMoney()
        {
            // Заранее делаем отписку для того, чтобы анимация сброса денег не прерывалась
            Messenger.RemoveListener(MessageType.PUSH_UNUSED_ITEMS, Remove);
            trigger.enabled = false;
            yield return new WaitForSeconds(collectionTime);
            enabled = false;
            yield return Collapse();
            ObjectsPool<Money>.Push(this);
            transform.localScale = Vector3.one;
        }

        // Удаляет неиспользованные деньги со сцены
        void Remove()
        {
            enabled = false;
            ObjectsPool<Money>.Push(this);
        }
    }
}


