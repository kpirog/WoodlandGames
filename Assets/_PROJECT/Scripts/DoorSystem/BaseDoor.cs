using UnityEngine;

namespace Woodland.DoorSystem
{
    public abstract class BaseDoor : MonoBehaviour
    {
        protected abstract void OnTriggerEnter(Collider other);
        protected abstract void OnTriggerExit(Collider other);
    }
}