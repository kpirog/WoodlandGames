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

            startLeftValue = doorLeft.transform.localPosition.x - doorLeft.localScale.x;
            startRightValue = doorRight.transform.localPosition.x + doorRight.localScale.x;

            startLeftPos = doorLeft.transform.localPosition;
            startRightPos = doorRight.transform.localPosition;
        }

        public void OpenDoor()
        {
            doorLeft.DOScaleX(0f, doorAnimationTime);
            doorLeft.DOLocalMoveX(startLeftValue, doorAnimationTime);

            doorRight.DOScaleX(0f, doorAnimationTime);
            doorRight.DOLocalMoveX(startRightValue, doorAnimationTime);
        }

        public void CloseDoor()
        {
            doorLeft.DOScaleX(startXScale, doorAnimationTime);
            doorLeft.DOLocalMove(startLeftPos, doorAnimationTime);

            doorRight.DOScaleX(startXScale, doorAnimationTime);
            doorRight.DOLocalMove(startRightPos, doorAnimationTime);
        }
    }
}
