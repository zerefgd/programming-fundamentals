using UnityEngine;

namespace Lesson01.Tasks
{

    public class CountdownTimer : MonoBehaviour
    {
        [SerializeField] private  float countdownTime = 1f;
        private void Update()
        {
            countdownTime -= Time.deltaTime;
            if(countdownTime <= 0f)
            {
                Debug.Log("Time's up!");
                enabled = false; // Disable this script to stop further updates
            }
        }
    }
}