using UnityEngine;

namespace Woodland.DoorSystem
{
    public class NormalDoor : BaseDoor
    {
        protected override void OnTriggerEnter(Collider other)
        {
            doorAnimation.OpenDoor();
        }

        protected override void OnTriggerExit(Collider other)
        {
            doorAnimation.CloseDoor();
        }
    }
}
