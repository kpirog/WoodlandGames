using UnityEngine;
using TMPro;

namespace Woodland.UI
{
    public class CoinView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI coinsCollectedText;

        public void SetViewData(int collectedCoins, int coinsCount)
        {
            coinsCollectedText.text = $"Coins: {collectedCoins} / {coinsCount}";
        }
    }
}