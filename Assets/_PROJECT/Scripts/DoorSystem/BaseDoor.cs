using UnityEngine;

namespace Woodland.DoorSystem
{
    public abstract class BaseDoor : MonoBehaviour
    {
        private DoorAnimation doorAnimation;

        protected virtual void Awake()
        {
            doorAnimation = GetComponent<DoorAnimation>();
        }

        protected abstract void OnTriggerEnter(Collider other);
        protected abstract void OnTriggerExit(Collider other);
    }
}