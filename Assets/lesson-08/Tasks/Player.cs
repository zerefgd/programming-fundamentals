using UnityEngine;
namespace Lesson08.Tasks
{

    [System.Serializable]
    public class HealthSystem
    {
        public int currentHealth = 100;
        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
        }
    }

    public class Player : MonoBehaviour
    {
        private HealthSystem healthSystem = new HealthSystem();
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                healthSystem.TakeDamage(10);
                Debug.Log("Player Health: " + healthSystem.currentHealth);
            }
        }
    }
}