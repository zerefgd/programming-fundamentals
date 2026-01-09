using UnityEngine;

namespace Lesson01.Examples
{
    public class HealthSystem : MonoBehaviour
    {
        [SerializeField] private int maxHealth = 100;
        private int currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
            Debug.Log($"Player health initialized to {currentHealth}/{maxHealth}");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                TakeDamage(10);
            }
        }

        private void TakeDamage(int damage)
        {
            currentHealth -= damage;
            currentHealth = Mathf.Max(currentHealth, 0);
            Debug.Log($"Player took {damage} damage, current health: {currentHealth}/{maxHealth}");
            if(currentHealth <= 0)
            {
                Debug.Log("Player has died.");
            }
        }
    }
}

