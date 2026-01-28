using UnityEngine;

namespace Lesson11.Examples
{

    public class LightSwitch : Interactable
    {
        public override void OnInteract()
        {
            Debug.Log("You have toggled the light switch!");
        }
    }
}