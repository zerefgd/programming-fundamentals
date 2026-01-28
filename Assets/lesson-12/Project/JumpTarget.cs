using UnityEngine;

namespace Lesson12.Project
{
    public class JumpTarget : MonoBehaviour, IShootable
    {
        public void OnHit()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }
    }
}