using UnityEngine;

namespace Lesson09.Project
{
    public class BaseInteractable : MonoBehaviour
    {
        [SerializeField] protected string objectName = "Interact";
        [SerializeField] protected bool isInteractable = true;
        public virtual void Interact(GameObject interactor)
        {
            if(!isInteractable)
            {
                Debug.Log(gameObject.name + " is not interactable at the moment.");
                return;
            }
            Debug.Log("Base interaction with " + gameObject.name);
        }

        public void SetInteractable(bool value)
        {
            isInteractable = value;
            Debug.Log(gameObject.name + " interactable set to " + isInteractable);
        }
    }
}