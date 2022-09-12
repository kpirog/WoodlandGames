using System.Collections.Generic;
using UnityEngine;
using Woodland.Core;

namespace Woodland.EnemySystem
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private EnemySpawnData[] enemySpawnData;

        private List<Enemy> enemies;
        
        private GameController gameController;

        private void Awake()
        {
            gameController = FindObjectOfType<GameController>();
            enemies = new List<Enemy>();
        }

        private void OnEnable()
        {
            gameController.onLostHealth += ResetEnemies;
            gameController.onGameFinished += StopEnemies;
        }

        private void OnDisable()
        {
            gameController.onLostHealth -= ResetEnemies;
            gameController.onGameFinished -= StopEnemies;
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

                enemies.Add(enemy);
            }
        }

        private void ResetEnemies()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.ResetPositionAndRotation();
            }
        }

        private void StopEnemies(bool state)
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.DisableMovement();
            }
        }
    }
}