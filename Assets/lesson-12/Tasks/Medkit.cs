using UnityEngine;

namespace Lesson12.Tasks
{
    public class Medkit : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<IHealable>(out var healable))
            {
                healable.Heal(20);
                Debug.Log("Medkit used to heal 20 health.");
                Destroy(gameObject); // Destroy the medkit after use
            }
        }
    }
}
