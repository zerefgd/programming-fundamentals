using UnityEngine;

namespace Lesson11.Project
{
    public abstract class TrapBase : MonoBehaviour
    {
        public int DamageAmount = 10;
        public abstract void TriggerTrap(GameObject target);
    }
}