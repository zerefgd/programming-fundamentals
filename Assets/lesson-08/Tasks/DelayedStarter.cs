using UnityEngine;

namespace Lesson08.Tasks
{
    public class DelayedStarter : MonoBehaviour
    {
        public float delay = 3f;
        private float timer = 0f;
        private bool canCount = true;

        private void Update()
        {
            timer += Time.deltaTime;
            if(canCount && timer >= delay)
            {
                Debug.Log("Ready To Go!");
                canCount = false;
            }
        }
    }
}