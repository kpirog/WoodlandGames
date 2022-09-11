using UnityEngine;

namespace Woodland.DoorSystem
{
    public abstract class BaseDoor : MonoBehaviour
    {
        protected DoorAnimation doorAnimation;

        protected virtual void Awake()
        {
            doorAnimation = GetComponent<DoorAnimation>();
        }

        protected abstract void OnTriggerEnter(Collider other);
        protected abstract void OnTriggerExit(Collider other);
    }
}