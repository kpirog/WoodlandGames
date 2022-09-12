using UnityEngine;
using UnityEngine.AI;
using StarterAssets;

namespace Woodland.EnemySystem
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Enemy : MonoBehaviour
    {
        private Vector3 startPosition;
        private Quaternion startRotation;

        private Transform target;
        private NavMeshAgent agent;
        
        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        private void Start()
        {
            startPosition = transform.position;
            startRotation = transform.rotation;
            target = FindObjectOfType<ThirdPersonController>().transform;
        }

        private void Update()
        {
            if (target == null) return;

            ChaseTarget(target.position);
        }

        private void ChaseTarget(Vector3 targetPosition)
        {
            agent.SetDestination(targetPosition);
        }

        public void SetMovementSpeed(float speed)
        {
            agent.speed = speed;
        }

        public void ResetPositionAndRotation()
        {
            transform.position = startPosition;
            transform.rotation = startRotation;
        }

        public void DisableMovement()
        {
            agent.isStopped = true;
        }
    }
}