using UnityEngine;

namespace Lesson10.Examples
{
    public class GoblinEnemy : Enemy
    {
        public override void Attack()
        {
            Debug.Log($"{enemyName} the Goblin swings its club!");
        }

        protected override void Die()
        {
            Debug.Log($"{enemyName} the Goblin lets out a final screech before dying!");
            base.Die();
        }
    }
}