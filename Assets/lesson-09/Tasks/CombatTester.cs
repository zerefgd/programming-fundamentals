using UnityEngine;

namespace Lesson09.Tasks
{
    public class CombatTester : MonoBehaviour
    { 
        public BaseCharacterStats player;
        public BaseCharacterStats enemy;

        private void Start()
        {
            if(player == null || enemy == null)
            {
                Debug.LogError("Player or Enemy reference is missing in CombatTester.");
                return;
            }

            Debug.Log("Combat Test Started");

            Debug.Log($"Player Health: {player.GetCurrentHealth()}/{player.GetMaxHealth()}");
            Debug.Log($"Enemy Health: {enemy.GetCurrentHealth()}/{enemy.GetMaxHealth()}");
            // Simulate combat
            Debug.Log("Player attacks Enemy");
            player.TakeDamage(enemy.GetStrength());

            Debug.Log("Enemy attacks Player");
            enemy.TakeDamage(player.GetStrength());

            Debug.Log($"Post-Combat Player Health: {player.GetCurrentHealth()}/{player.GetMaxHealth()}");
            Debug.Log($"Post-Combat Enemy Health: {enemy.GetCurrentHealth()}/{enemy.GetMaxHealth()}");

        }
    }
}