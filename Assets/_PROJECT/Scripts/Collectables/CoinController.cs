using UnityEngine;
using UnityEngine.Events;
using Woodland.Core;
using Woodland.UI;

namespace Woodland.Collectables
{
    public class CoinController : MonoBehaviour
    {
        [SerializeField] private CoinView coinView;

        private Coin[] coins;
        private int coinsCollected = 0;
        private GameController gameController;

        [HideInInspector] public UnityEvent onCoinCollected;

        private void Awake()
        {
            coins = FindObjectsOfType<Coin>();
            gameController = FindObjectOfType<GameController>();
        }

        private void Start()
        {
            coinView.SetViewData(coinsCollected, coins.Length);
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
            coinsCollected++;
            coinView.SetViewData(coinsCollected, coins.Length);

            if (coinsCollected == coins.Length)
            {
                gameController.LoadNextLevel();
            }
        }
    }
}