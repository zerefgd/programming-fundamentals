using UnityEngine;

namespace Lesson10.Tasks
{
    public abstract class EnemyMovement : MonoBehaviour
    {
        public float moveSpeed = 2f;
        public string enemyType = "Generic Enemy";
        public abstract void MoveTowards(Vector3 target);
    }
}