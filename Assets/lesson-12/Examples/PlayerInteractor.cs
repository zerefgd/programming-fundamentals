using UnityEngine;

namespace Lesson12.Examples
{
    public class PlayerInteractor : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 2f);
                if (hit.collider != null)
                {
                    IInteractable interactable = hit.collider.GetComponent<IInteractable>();
                    if (interactable != null)
                    {
                        interactable.Interact(gameObject);
                    }
                }
            }
        }
    }
}