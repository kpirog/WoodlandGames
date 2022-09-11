using UnityEngine;

namespace Woodland.EnemySystem
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private EnemySpawnData[] enemySpawnData;

        private int levelIndex = 0;

        private void Start()
        {
            SpawnEnemies();
        }

        private void SpawnEnemies()
        {
            EnemySpawnData currentSpawnData = enemySpawnData[levelIndex];
            
            for (int i = 0; i < currentSpawnData.EnemyCount; i++)
            {
                Enemy enemy = Instantiate(currentSpawnData.EnemyPrefab, currentSpawnData.SpawnPoints[i], Quaternion.identity);
                enemy.transform.SetParent(transform);
                enemy.SetMovementSpeed(currentSpawnData.EnemySpeed);
            }
        }
    }
}