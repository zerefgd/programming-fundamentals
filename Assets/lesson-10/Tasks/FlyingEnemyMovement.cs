using UnityEngine;

namespace Lesson10.Tasks
{
    public class FlyingEnemyMovement : EnemyMovement
    {
        void Start()
        {
            enemyType = "Flying Enemy";
        }

        public override void MoveTowards(Vector3 target)
        {
            Vector3 direction = (target - transform.position).normalized;
            transform.position 
                = Vector3.MoveTowards(
                    transform.position, target, moveSpeed * Time.deltaTime * 0.5f);
            if(direction != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(
                    transform.rotation, toRotation, 360 * Time.deltaTime);
            }
        }
    }
}