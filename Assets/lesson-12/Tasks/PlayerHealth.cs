using UnityEngine;

namespace Lesson12.Tasks
{
    public class PlayerHealth : MonoBehaviour,IHealable
    {
        public int health = 100;
        public void Heal(int healAmount)
        {
            health += healAmount;
            Debug.Log($"Player healed by {healAmount}. Current health: {health}");
            // Implement healing logic here
        }
    }
}