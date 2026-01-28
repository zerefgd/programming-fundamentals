using UnityEngine;

namespace Lesson11.Examples
{
    public class TreasureChest : Interactable
    {
        public override void OnInteract()
        {
            Debug.Log("You have opened the treasure chest!");
        }
    }
}