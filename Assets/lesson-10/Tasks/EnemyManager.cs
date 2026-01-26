using UnityEngine;

namespace Lesson10.Tasks
{
    public class EnemyManager : MonoBehaviour
    {
        public EnemyMovement[] enemyMovements;
        public Transform playerTransform;

        private void Start()
        {
            if (playerTransform == null)
            {
                Debug.LogError("Player Transform is not assigned in EnemyManager.");
            }

            if(enemyMovements == null || enemyMovements.Length == 0)
            {
                Debug.LogError("No EnemyMovement components assigned in EnemyManager.");
            }
        }

        private void Update()
        {
            if(playerTransform == null || enemyMovements == null) return;
            foreach (var enemyMovement in enemyMovements)
            {
                if(enemyMovement != null)
                {
                    enemyMovement.MoveTowards(playerTransform.position);
                }
            }
        }
    }
}