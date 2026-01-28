using UnityEngine;

namespace Lesson11.Examples
{
    public abstract class Interactable : MonoBehaviour
    {
        [Header("Interaction Settings")]
        public string promptText = "Press E to interact";
        public abstract void OnInteract();
        public void ShowPrompt()
        {
            Debug.Log(promptText);
        }
    }
}