using TMPro;
using UnityEngine;

namespace Lesson10.Examples
{
    public class PlayerInteractor : MonoBehaviour
    {
        public float interactionRange = 3f;
        public TMP_Text interactionText;
        private void Start()
        {
        }
        private void Update()
        {
            TryInteract();
        }
        private void TryInteract()
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            IInteractable interactable;
            string prompt;
            if (Physics.Raycast(ray, out hit, interactionRange))
            {
                interactable = hit.collider.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    prompt = "Press E to " + interactable.GetInteractionPrompt();
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        interactable.Interact(gameObject);
                    }
                    interactionText.text = prompt;
                }
            }
        }
    }
}