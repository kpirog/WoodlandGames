using UnityEngine;
using DG.Tweening;

namespace Woodland.DoorSystem
{
    public class DoorAnimation : MonoBehaviour
    {
        [SerializeField] private Transform doorLeft;
        [SerializeField] private Transform doorRight;
        [SerializeField] private float doorAnimationTime = 2f;

        private float startLeftValue;
        private float startRightValue;
        private float startXScale;

        private Vector3 startLeftPos;
        private Vector3 startRightPos;

        private void Start()
        {
            startXScale = doorLeft.localScale.x;

            startLeftValue = doorLeft.transform.position.x - doorLeft.localScale.x;
            startRightValue = doorRight.transform.position.x + doorRight.localScale.x;

            startLeftPos = doorLeft.transform.position;
            startRightPos = doorRight.transform.position;
        }

        public void OpenDoor()
        {
            doorLeft.DOScaleX(0f, doorAnimationTime);
            doorLeft.DOMoveX(startLeftValue, doorAnimationTime);

            doorRight.DOScaleX(0f, doorAnimationTime);
            doorRight.DOMoveX(startRightValue, doorAnimationTime);
        }

        public void CloseDoor()
        {
            doorLeft.DOScaleX(startXScale, doorAnimationTime);
            doorLeft.DOMove(startLeftPos, doorAnimationTime);

            doorRight.DOScaleX(startXScale, doorAnimationTime);
            doorRight.DOMove(startRightPos, doorAnimationTime);
        }
    }
}
