using UnityEngine;
using UnityEngine.Events;
using Woodland.UI;

namespace Woodland.Collectables
{
    public class CoinController : MonoBehaviour
    {
        [SerializeField] private CoinView coinView;

        private Coin[] coins;
        private int coinsCollectedAmount = 0;

        [HideInInspector] public UnityEvent onCoinCollected;

        private void Awake()
        {
            coins = FindObjectsOfType<Coin>();
        }

        private void Start()
        {
            coinView.SetViewData(coinsCollectedAmount, coins.Length);
        }

        private void OnEnable()
        {
            onCoinCollected.AddListener(UpdateCollected);
        }

        private void OnDisable()
        {
            onCoinCollected.RemoveListener(UpdateCollected);
        }

        private void UpdateCollected()
        {
            coinsCollectedAmount++;
            coinView.SetViewData(coinsCollectedAmount, coins.Length);
        }
    }
}