using UnityEngine;

namespace Lesson11.Examples
{
    public class PlayerInteractor : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject hitObject = GetLookedAtObject();
                if (hitObject == null) return;
                Interactable interactable = hitObject.GetComponent<Interactable>();
                if (interactable == null) return;
                interactable.OnInteract();
                interactable.ShowPrompt();
            }
        }

        private GameObject GetLookedAtObject()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 15f))
            {
                Debug.Log($"Hit object: {hitInfo.collider.gameObject.name}");
                return hitInfo.collider.gameObject;
            }
            return null;
        }
    }
}