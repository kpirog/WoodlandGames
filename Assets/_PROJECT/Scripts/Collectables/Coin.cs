using UnityEngine;

namespace Woodland.Collectables
{
    public class Coin : MonoBehaviour
    {
        private CoinController coinController;

        private void Awake()
        {
            coinController = GetComponentInParent<CoinController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                coinController.onCoinCollected?.Invoke();
                gameObject.SetActive(false);
            }
        }
    }
}