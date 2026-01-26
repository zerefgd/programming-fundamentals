using UnityEngine;

namespace Lesson10.Examples
{
    public class Enemy : MonoBehaviour
    {
        public string enemyName = "Generic Enemy";
        public int health = 100;

        public virtual void Attack()
        {
            Debug.Log($"{enemyName} attacks generically!");
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            Debug.Log($"{enemyName} took {damage} damage. Remaining health: {health}");
            if (health <= 0)
            {
                Die();
            }
        }

        protected virtual void Die()
        {
            Debug.Log($"{enemyName} died generically!");
            Destroy(gameObject);
        }
    }
}