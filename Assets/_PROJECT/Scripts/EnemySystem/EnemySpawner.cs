using UnityEngine;
using Woodland.Core;

namespace Woodland.EnemySystem
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private EnemySpawnData[] enemySpawnData;

        private GameController gameController;

        private void Awake()
        {
            gameController = FindObjectOfType<GameController>();
        }

        private void Start()
        {
            SpawnEnemies();
        }

        private void SpawnEnemies()
        {
            EnemySpawnData currentSpawnData = enemySpawnData[gameController.LevelIndex];
            
            for (int i = 0; i < currentSpawnData.EnemyCount; i++)
            {
                Enemy enemy = Instantiate(currentSpawnData.EnemyPrefab, currentSpawnData.SpawnPoints[i], Quaternion.identity);
                enemy.transform.SetParent(transform);
                enemy.SetMovementSpeed(currentSpawnData.EnemySpeed);
            }
        }
    }
}