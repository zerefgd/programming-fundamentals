using UnityEngine;

namespace Lesson10.Examples
{

    public class OrcEnemy : Enemy
    {
        public override void Attack()
        {
            Debug.Log($"{enemyName} the Orc slashes with its axe!");
        }

        protected override void Die()
        {
            Debug.Log($"{enemyName} the Orc roars defiantly before falling!");
            base.Die();
        }
    }
}