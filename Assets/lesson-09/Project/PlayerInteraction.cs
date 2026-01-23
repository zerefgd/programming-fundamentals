using UnityEngine;

namespace Lesson09.Project
{
    public class PlayerInteraction : MonoBehaviour
    {
        public float interactionRange = 3f;
        public KeyCode interactionKey = KeyCode.E;  
        void Update()
        {
            if (Input.GetKeyDown(interactionKey))
            {
                TryInteract();
            }
        }

        private void TryInteract()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, interactionRange))
            {
                BaseInteractable interactable = hit.collider.GetComponent<BaseInteractable>();
                if (interactable != null)
                {
                    Debug.Log("Interacting with " + interactable.gameObject.name);
                    interactable.Interact(this.gameObject);
                }
                else
                {
                    Debug.Log("No interactable object in range.");
                }
            }
            else
            {
                Debug.Log("No object hit by raycast.");
            }
        }

        public void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(transform.position, transform.forward * interactionRange);
            Gizmos.DrawWireSphere(transform.position + transform.forward * interactionRange, 0.2f);
        }
    }
}