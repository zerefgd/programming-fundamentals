using UnityEngine;

namespace Lesson10.Examples
{
    public class Lever : MonoBehaviour,IInteractable
    {
        public bool IsPulled = false;
        public string leverName = "Ancient Lever";
        public void Interact(GameObject interactor)
        {
            IsPulled = !IsPulled;
            Debug.Log(IsPulled ? "The lever has been pulled." : "The lever has been reset.");
        }
        public string GetInteractionPrompt()
        {
            return IsPulled ? "Reset the lever" : "Pull the lever";
        }
    }
}