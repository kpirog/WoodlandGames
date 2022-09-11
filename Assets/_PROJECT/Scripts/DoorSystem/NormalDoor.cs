using UnityEngine;

namespace Woodland.DoorSystem
{
    public class NormalDoor : BaseDoor
    {
        protected override void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") || other.CompareTag("Enemy"))
            {

            }
        }

        protected override void OnTriggerExit(Collider other)
        {
            
        }
    }
}
