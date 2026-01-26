using UnityEngine;

namespace Lesson10.Examples
{
    public interface IInteractable
    {
        void Interact(GameObject interactor);
        string GetInteractionPrompt();
    }

    public class Door : MonoBehaviour, IInteractable
    {
        public bool isOpen = false;
        public string doorName = "Mysterious Door";

        public void Interact(GameObject interactor)
        {
            isOpen = !isOpen;
            Debug.Log(isOpen ? "The door is now open." : "The door is now closed.");
        }
        public string GetInteractionPrompt()
        {
            return isOpen ? "Close the door" : "Open the door";
        }
    }
}