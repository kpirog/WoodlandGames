using UnityEngine;
using Woodland.Core;
using TMPro;

namespace Woodland.UI
{
    public class GameResultWindow : MonoBehaviour
    {
        [SerializeField] private GameObject gameResultPanel;
        [SerializeField] private TextMeshProUGUI resultText;
        
        private GameController gameController;

        private void Awake()
        {
            gameController = FindObjectOfType<GameController>();
        }

        private void OnEnable()
        {
            gameController.onGameFinished += OpenPanel;
        }
        private void OnDisable()
        {
            gameController.onGameFinished -= OpenPanel;
        }

        private void OpenPanel(bool gameState)
        {
            resultText.text = gameState ? "You Win" : "You Lose";
            gameResultPanel.SetActive(true);
        }

        public void MainMenuButton()
        {
            gameController.BackToMenu();
        }

        public void RestartButton()
        {
            gameController.RestartGame();
        }
    }
}