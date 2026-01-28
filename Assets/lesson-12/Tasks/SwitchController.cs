using UnityEngine;

namespace Lesson12.Tasks
{
    public class SwitchController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MonoBehaviour[] allBehaviours = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);
                foreach (var behaviour in allBehaviours)
                {
                    if (behaviour is ISwitchable switchable)
                    {
                        switchable.SwitchOn();
                    }
                }
            }
        }
    }
}