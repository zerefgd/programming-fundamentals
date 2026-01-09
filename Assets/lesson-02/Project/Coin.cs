using UnityEngine;

namespace Lesson02.Project
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int coinValue = 10;
        private bool isCollected = false;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!isCollected && collision.CompareTag("Player"))
            {
                isCollected = true;
                ScoreManager.Instance.AddScore(coinValue);
                Destroy(gameObject);
            }
        }
    }
}