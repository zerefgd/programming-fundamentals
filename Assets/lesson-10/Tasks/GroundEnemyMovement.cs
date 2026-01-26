using UnityEngine;

namespace Lesson10.Tasks
{
    public class GroundEnemyMovement : EnemyMovement
    {
        private void Start()
        {
            enemyType = "Ground Enemy";
        }
        public override void MoveTowards(Vector3 target)
        {
            Vector3 direction = (target - transform.position).normalized;
            direction.y = 0; // Ensure movement is only on the ground plane
            transform.position 
                = Vector3.MoveTowards(
                    transform.position, target, moveSpeed * Time.deltaTime);
            if(direction != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(
                    transform.rotation, toRotation, 360 * Time.deltaTime);
            }
        }
    }
}