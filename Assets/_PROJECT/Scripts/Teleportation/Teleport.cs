using UnityEngine;

namespace Woodland.Teleportation
{
    public class Teleport : MonoBehaviour
    {
        [SerializeField] private Transform destination;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.transform.position = destination.position;
            }
        }
    }
}