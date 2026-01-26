using UnityEngine;

namespace Lesson10.Examples
{
    public class EnemyTester : MonoBehaviour
    {
        public Enemy targetEnemy;
        public Enemy[] enemies;

        private void Start()
        {
            if (targetEnemy == null)
            {
                Debug.LogError("No target enemy assigned!");
                return;
            }

            Debug.Log($"Testing enemy: {targetEnemy.enemyName}");
            targetEnemy.Attack();
            targetEnemy.TakeDamage(30);
            targetEnemy.TakeDamage(80); // This should trigger death
        }


        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var enemy in enemies)
                {
                    if (enemy != null)
                    {
                        Debug.Log($"Testing enemy: {enemy.enemyName}");
                        enemy.Attack();
                        enemy.TakeDamage(50);
                    }
                }
            }
        }
    }
}