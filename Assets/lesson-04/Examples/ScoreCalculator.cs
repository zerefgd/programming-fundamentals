using UnityEngine;

namespace Lesson04.Examples
{

    public class ScoreCalculator : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int totalScore = AddScore(100, 50);
            Debug.Log("Total Score: " + totalScore);

            if(IsPlayerAlive(0))
            {
                Debug.Log("Player is alive.");
            }
            else
            {
                Debug.Log("Player is dead.");
            }
    }

        private int AddScore(int score1, int score2)
        {
            return score1 + score2;
        }

        private bool IsPlayerAlive(int health)
        {
            return health > 0;
        }
    }
}