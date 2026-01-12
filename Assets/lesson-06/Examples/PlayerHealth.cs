using UnityEngine;

namespace Lesson06.Examples
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _currentHealth = 100;
        public int CurrentHealth
        {
            get => _currentHealth;
            private set => _currentHealth = Mathf.Clamp(value, 0, 100);
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            Debug.Log("Player took damage. Current Health: " + CurrentHealth);
            if (CurrentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log("Player has died.");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(20);
            }
        }
    }
}