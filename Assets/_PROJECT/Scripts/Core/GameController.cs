using UnityEngine;
using UnityEngine.SceneManagement;

namespace Woodland.Core
{
    public class GameController : MonoBehaviour
    {
        private int levelIndex = 0;

        public int LevelIndex => levelIndex;

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public void StartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void LoadNextLevel()
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            UpdateLevel(sceneIndex + 1);

            if (levelIndex < 2)
            {
                SceneManager.LoadScene(sceneIndex);
            }
            else
            {
                //you win
            }
        }

        private void UpdateLevel(int nextLevelIndex)
        {
            if (nextLevelIndex > 1)
            {
                levelIndex++;
            }
        }
    }
}