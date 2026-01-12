using UnityEngine;

namespace Lesson04.Tasks
{
    public class HealthClamper : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int safeHealth = ClampedHealth(150);
            Debug.Log(safeHealth);
            safeHealth = ClampedHealth(-20);
            Debug.Log(safeHealth);
        }

        private int ClampedHealth(int health)
        {
            return Mathf.Clamp(health, 0, 100);
        }
    }
}