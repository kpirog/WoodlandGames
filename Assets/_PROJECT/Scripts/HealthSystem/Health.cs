using UnityEngine;
using Woodland.UI;

namespace Woodland.HealthSystem
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int lives = 3;
        [SerializeField] private HealthView healthView;

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
                //gameover
            }
        }
    }
}