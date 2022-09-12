using UnityEngine;
using Woodland.Core;

namespace Woodland.UI
{
    public class MainMenu : MonoBehaviour
    {
        private GameController gameController;

        private void Awake()
        {
            gameController = FindObjectOfType<GameController>();
        }

        public void PlayButton()
        {
            gameController.StartGame();
        }

        public void QuitButton()
        {
            Application.Quit();
        }
    }
}
