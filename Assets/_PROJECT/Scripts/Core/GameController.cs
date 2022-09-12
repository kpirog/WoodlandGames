using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace Woodland.Core
{
    public class GameController : MonoBehaviour
    {
        private int levelIndex = 0;
        public int LevelIndex => levelIndex;

        public event Action onLostHealth;
        public event Action<bool> onGameFinished;


        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        private void UpdateLevel(int nextLevelIndex)
        {
            if (nextLevelIndex > 1)
            {
                levelIndex++;
            }
        }

        private void LoadScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }

        public void StartGame()
        {
            LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void RestartGame()
        {
            levelIndex = 0;
            LoadScene(1);
        }

        public void BackToMenu()
        {
            levelIndex = 0;
            LoadScene(0);
        }

        public void FinishLevel()
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            UpdateLevel(sceneIndex + 1);

            if (levelIndex < 2)
            {
                LoadScene(sceneIndex);
            }
            else
            {
                OnGameFinished(true);
            }
        }

        public void OnGameFinished(bool state)
        {
            onGameFinished?.Invoke(state);
        }

        public void OnLostHealth()
        {
            onLostHealth?.Invoke();
        }
    }
}