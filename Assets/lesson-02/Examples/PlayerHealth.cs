using UnityEngine;
using UnityEngine.UIElements;

namespace Lesson02.Examples
{
    public class PlayerHealth : MonoBehaviour
    {

        [SerializeField] private int maxHealth = 100;
        private int currentHealth;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            currentHealth = maxHealth;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                TakeDamage(25);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                Heal(15);
            }
        }

        private void TakeDamage(int damage)
        {
            currentHealth -= damage;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            Debug.Log("Player took damage. Current Health: " + currentHealth);
        }

        private void Heal(int amount)
        {
            currentHealth += amount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            Debug.Log("Player healed. Current Health: " + currentHealth);
        }
    }
}