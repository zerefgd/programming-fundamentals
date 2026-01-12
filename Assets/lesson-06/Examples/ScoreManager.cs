using TMPro;
using UnityEngine;

namespace Lesson06.Examples
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private int _score = 0;
        [SerializeField] private TMP_Text _scoreText;
        public int Score
        {
            get => _score;
            set
            {
                if (value < 0)
                {
                    Debug.LogWarning("Score cannot be negative. Setting to 0.");
                    _score = 0;
                }
                else
                {
                    if (_scoreText != null)
                    {
                        _scoreText.text = "Score: " + value.ToString();
                    }
                    else
                    {
                        Debug.LogWarning("Score Text is not assigned.");
                    }
                    _score = value;
                }
            }
        }

        private void Start()
        {
            Score = 0;
        }
    }
}