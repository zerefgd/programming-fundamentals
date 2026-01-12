using UnityEngine;

namespace Lesson04.Examples
{

    public class PlayerHealth : MonoBehaviour
    {
        int currentHealth = 100;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(10);
            }
        }

        private void TakeDamage(int damage)
        {
            currentHealth -= damage;
            Debug.Log("Player took " + damage + " damage. Current health: " + currentHealth);
            if (currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log("Player has died.");
            Destroy(gameObject);
        }
    }
}