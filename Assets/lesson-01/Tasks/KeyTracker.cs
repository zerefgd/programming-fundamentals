using UnityEngine;

namespace Lesson01.Tasks
{
    public class KeyTracker : MonoBehaviour
    {
        private bool hasKey = false;

        private void PickUpKey()
        {
            hasKey = true;
            Debug.Log("Key picked up!");
        }

        private void UseKey()
        {
            if (hasKey)
            {
                Debug.Log("Key used to unlock the door!");
                hasKey = false;
            }
            else
            {
                Debug.Log("No key to use!");
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                PickUpKey();
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                UseKey();
            }
        }
    }
}