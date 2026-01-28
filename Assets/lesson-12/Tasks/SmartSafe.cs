using Lesson12.Examples;
using UnityEngine;

namespace Lesson12.Tasks
{

    public class SmartSafe : MonoBehaviour,IDamageable,IInteractable
    {
        [SerializeField] private int health = 100;
        private bool isOpen = false;
        public void TakeDamage(int damage)
        {
            health -= damage;
            Debug.Log($"Safe took {damage} damage, remaining health: {health}");
            if (health <= 0)
            {
                Debug.Log("Safe is destroyed!");
                Destroy(gameObject);
            }
        }
        public void Interact(GameObject other)
        {
            if (isOpen)
            {
                Debug.Log("The safe is already open.");
            }
            else if (health > 0)
            {
                isOpen = true;
                Debug.Log("You have opened the safe!");
            }
            else
            {
                Debug.Log("The safe is destroyed and cannot be opened.");
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact(gameObject);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                TakeDamage(25);
            }
        }
    }
}