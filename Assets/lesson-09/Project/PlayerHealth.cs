using UnityEngine;

namespace Lesson09.Project
{
    public class PlayerHealth : MonoBehaviour
    {
        public int maxHealth = 100;
        public int currentHealth = 0;
        public void Heal(int amount)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            Debug.Log("Player healed by " + amount + ". Current health: " + currentHealth);
        }
    }
}