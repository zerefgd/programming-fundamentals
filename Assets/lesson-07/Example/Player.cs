using System.Collections.Generic;
using UnityEngine;

namespace Lesson07.Examples
{
    public class Player : MonoBehaviour
    {
        public List<Enemy> specificEnemies;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var enemy in specificEnemies)
                {
                    enemy.AttackPlayer();
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Enemy.IncreaseDifficulty();
            }
        }
    }
}