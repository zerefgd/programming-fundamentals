using TMPro;
using UnityEngine;

namespace Lesson02.Project
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance { get; private set; }
        [SerializeField] private TMP_Text _scoreText;
        private int score = 0;
        private int maxScore = 100;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            score = 0;
            Debug.Log("Score: " + score);
            _scoreText.text = score.ToString();
        }

        public void AddScore(int amount)
        {
            score += amount;
            Debug.Log("Score: " + score);
            _scoreText.text = score.ToString();
            if (score >= maxScore)
            {
                Debug.Log("Max Score Reached!");
                _scoreText.text = "Max Score Reached!";
            }
        }
    }
}