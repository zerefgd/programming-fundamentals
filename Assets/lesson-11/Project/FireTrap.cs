using UnityEngine;

namespace Lesson11.Project
{
    public class FireTrap : TrapBase
    {
        public override void TriggerTrap(GameObject target)
        {
            var trapTester = target.GetComponent<TrapTester>();
            if (trapTester != null)
            {
                trapTester.ApplyDamage(DamageAmount);
            }
        }
    }
}