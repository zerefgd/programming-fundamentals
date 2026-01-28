using UnityEngine;

namespace Lesson12.Examples
{
    public class TreasureChest : MonoBehaviour, IInteractable
    {
        public void Interact(GameObject interactor)
        {
            Debug.Log("You have opened the treasure chest!");
            Destroy(gameObject);
        }
    }
}