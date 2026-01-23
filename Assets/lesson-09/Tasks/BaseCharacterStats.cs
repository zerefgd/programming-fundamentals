using UnityEngine;
using UnityEngine.UI;

namespace Lesson09.Tasks
{
    public class BaseCharacterStats : MonoBehaviour
    {
        [SerializeField] protected int maxHealth = 100;
        [SerializeField] protected int currentHealth;
        [SerializeField] protected int strength = 10;
        [SerializeField] protected int defense = 5;

        protected virtual void Awake()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(int rawDamage)
        {
            Debug.Log($"{gameObject.name} took {rawDamage} damage, current health: {currentHealth}");
            CalculateDamageTaken(rawDamage);
            if (currentHealth <= 0) Die();
        }

        protected virtual void CalculateDamageTaken(int rawDamage)
        {
            int damageTaken = Mathf.Max(rawDamage - defense, 0);
            currentHealth -= damageTaken;
            currentHealth = Mathf.Max(currentHealth, 0);
            Debug.Log($"{gameObject.name} took {damageTaken} damage after defense, current health: {currentHealth}");
        }

        protected virtual void Die()
        {
            Debug.Log($"{gameObject.name} has died.");
            // Additional death logic can be implemented here
            Destroy(gameObject);
        }

        public int GetCurrentHealth()
        {
            return currentHealth;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }
        public int GetStrength()
        {
            return strength;
        }
    }
}