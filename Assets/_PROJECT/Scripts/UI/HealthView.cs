using TMPro;
using UnityEngine;

namespace Woodland.UI
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI livesText;

        public void SetViewData(int lives)
        {
            livesText.text = $"Lives: {lives}";
        }
    }
}