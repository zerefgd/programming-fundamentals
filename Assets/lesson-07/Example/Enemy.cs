using UnityEngine;

namespace Lesson07.Examples
{

    public class Enemy : MonoBehaviour
    {
        public int Health = 100;
        public static float globalDamageMutiplier = 1.0f;

        public void AttackPlayer()
        {
            float damageToDeal = 10.0f * globalDamageMutiplier;
            Debug.Log($"Enemy attacks player for {damageToDeal} damage!");
        }

        public static void IncreaseDifficulty ()
        {
            globalDamageMutiplier += 0.5f;
            Debug.Log($"Global damage multiplier set to {globalDamageMutiplier}");
        }
    }
}