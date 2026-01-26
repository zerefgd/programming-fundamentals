using UnityEngine;

namespace Lesson10.Examples
{
    public abstract class Pickup : MonoBehaviour
    {
        public string pickUpName = "Default Pickup";

        public abstract void OnPickedUp(GameObject pickerUpper);

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                OnPickedUp(other.gameObject);
                Destroy(gameObject);
            }
        }
    }
}