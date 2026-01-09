using UnityEngine;

namespace Lesson02.Examples
{

    public class ScoreManager : MonoBehaviour
    {
        public int score = 0;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                score += 10;
                Debug.Log("Score: " + score);
            }
        }
    }
}