using System.Collections.Generic;
using UnityEngine;

namespace Woodland.EnemySystem
{

    [CreateAssetMenu(fileName = "Enemy spawn data", menuName = "Spawn data/New spawn data")]
    public class EnemySpawnData : ScriptableObject
    {
        [SerializeField] private Enemy enemyPrefab;
        [SerializeField] private int enemyCount;
        [SerializeField] private float enemySpeed;
        [SerializeField] private List<Vector3> spawnPoints;

        public Enemy EnemyPrefab => enemyPrefab;
        public int EnemyCount => enemyCount;
        public float EnemySpeed => enemySpeed;
        public List<Vector3> SpawnPoints => spawnPoints;

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (enemyCount > spawnPoints.Count)
            {
                while (enemyCount > spawnPoints.Count)
                {
                    spawnPoints.Add(Vector3.zero);
                }
            }
            else if (enemyCount < spawnPoints.Count)
            {
                while (enemyCount < spawnPoints.Count)
                {
                    spawnPoints.RemoveAt(spawnPoints.Count - 1);
                }
            }
        }
#endif
    }
}