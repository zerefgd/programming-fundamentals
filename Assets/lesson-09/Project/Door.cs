using UnityEngine;

namespace Lesson09.Project
{
    public class Door : BaseInteractable
    {
        protected bool isOpen = false;
        [SerializeField] private Vector3 positionOffset = new Vector3(0, 5, 0);
        private Vector3 closedPosition;

        private void Awake()
        {
            closedPosition = transform.position;
            objectName = "Door";
        }

        public override void Interact(GameObject player)
        {
            if (!isInteractable)
            {
                Debug.Log(gameObject.name + " is not interactable at the moment.");
                return;
            }
            base.Interact(player);
            isOpen = !isOpen;
            transform.position = isOpen ? closedPosition + positionOffset : closedPosition;
            Debug.Log((isOpen ? "Opened " : "Closed ") + gameObject.name);
        }
    }
}