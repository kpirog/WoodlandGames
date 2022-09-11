using UnityEngine;

namespace Woodland.DoorSystem
{
    public class PlayerDoor : BaseDoor
    {
        protected override void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                doorAnimation.OpenDoor();
            }
        }

        protected override void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                doorAnimation.CloseDoor();
            }
        }
    }
}