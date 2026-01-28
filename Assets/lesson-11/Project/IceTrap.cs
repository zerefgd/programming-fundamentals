using UnityEngine;

namespace Lesson11.Project
{

    public class IceTrap : TrapBase
    {
        public float SlowDuration = 5f;
        public float SlowAmount = 0.5f;
        public override void TriggerTrap(GameObject target)
        {
            // Implement the logic to slow down the target
            var movement = target.GetComponent<TrapTester>();
            if (movement != null)
            {
                movement.ApplySlow(SlowAmount, SlowDuration);
            }
        }
    }
}