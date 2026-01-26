using UnityEngine;

namespace Lesson10.Examples
{
    public class PlayerHealth : MonoBehaviour
    {
        public int currentHealth = 100;
        public int maxHealth = 100;
        private void Start()
        {
            currentHealth = maxHealth;
            Debug.Log("PlayerHealth initialized with " + currentHealth + " health.");
        }

        public void TakeDamage(int amount)
        {
            currentHealth -= amount;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
            Debug.Log("Took " + amount + " damage. Current health: " + currentHealth);
        }

        public void Heal(int amount)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            Debug.Log("Healed " + amount + " health. Current health: " + currentHealth);
        }
    }
}