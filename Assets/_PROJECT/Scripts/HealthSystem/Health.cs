using UnityEngine;
using Woodland.Core;
using Woodland.UI;

namespace Woodland.HealthSystem
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int lives = 3;
        [SerializeField] private HealthView healthView;

        private GameController gameController;

        private void Awake()
        {
            gameController = FindObjectOfType<GameController>();
        }

        private void Start()
        {
            healthView.SetViewData(lives);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                DecreaseHealth();
            }
        }

        private void DecreaseHealth()
        {
            lives--;
            healthView.SetViewData(lives);

            if (lives <= 0)
            {
                gameController.OnGameFinished(false);
                return;
            }

            gameController.OnLostHealth();
        }
    }
}