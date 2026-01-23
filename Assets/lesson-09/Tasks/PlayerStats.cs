using UnityEngine;

namespace Lesson09.Tasks
{
    public class PlayerStats : BaseCharacterStats
    {
        protected override void Awake()
        {
            Debug.Log("PlayerStats Awake called");
            base.Awake();
            maxHealth = 150; // Player has higher max health
            currentHealth = maxHealth;
            strength = 20;   // Player has higher strength
            defense = 10;    // Player has higher defense
            Debug.Log($"Player initialized with Max Health: {maxHealth}, Strength: {strength}, Defense: {defense}");
        }

        protected override void CalculateDamageTaken(int rawDamage)
        {
            int heroicDefenseBonus = 5;
            int damageTaken = Mathf.Max(rawDamage - heroicDefenseBonus, 0); 
            Debug.Log($"Heroic defense bonus applied: {heroicDefenseBonus}");
            base.CalculateDamageTaken(damageTaken);
        }
    }
}