using UnityEngine;

namespace Lesson11.Tasks
{
    public class Slime : Enemy
    {
        private void Start()
        {
            Invoke("Die", 2f);
        }

        protected override void OnDeathEffect()
        {
            Debug.Log("Slime has died with a squishy effect.");
        }
    }
}