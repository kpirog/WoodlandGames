using UnityEngine;
using UnityEngine.AI;

namespace Woodland.EnemySystem
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 5f;
        [SerializeField] private Transform target;

        private NavMeshAgent agent;
        
        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
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
    }
}