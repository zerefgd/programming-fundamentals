using UnityEngine;

namespace Lesson09.Tasks
{
    public class EnemyStats : BaseCharacterStats
    {
        protected override void Awake()
        {
            Debug.Log("EnemyStats Awake called");
            base.Awake();
            maxHealth = 80; // Enemy has lower max health
            currentHealth = maxHealth;
            strength = 10;   // Enemy has moderate strength
            defense = 3;    // Enemy has lower defense
            Debug.Log($"Enemy initialized with Max Health: {maxHealth}, Strength: {strength}, Defense: {defense}");
        }
        protected override void CalculateDamageTaken(int rawDamage)
        {
            int ferocityPenalty = 2;
            int damageTaken = Mathf.Max(rawDamage + ferocityPenalty, 0); 
            Debug.Log($"Ferocity penalty applied: {ferocityPenalty}");
            base.CalculateDamageTaken(damageTaken);
        }
    }
}