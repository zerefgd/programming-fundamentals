using UnityEngine;

namespace Lesson11.Tasks
{
    public abstract class Enemy : MonoBehaviour
    {
        protected abstract void OnDeathEffect();
        public void Die()
        {
            Debug.Log("Enemy has died.");
            OnDeathEffect();
            Destroy(gameObject);
        }
    }
}