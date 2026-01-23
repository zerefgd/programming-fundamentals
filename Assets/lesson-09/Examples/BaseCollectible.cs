using UnityEngine;

namespace Lesson09.Examples
{
    public class BaseCollectible : MonoBehaviour
    {
        [SerializeField] protected GameObject collectEffectPrefab;

        public virtual void Collect()
        {
            Debug.Log("BaseCollectible collected!");
            PlayCollectEffect();
            Destroy(gameObject);
        }

        protected virtual void PlayCollectEffect()
        {
            if (collectEffectPrefab != null)
            {
                Instantiate(collectEffectPrefab, transform.position, Quaternion.identity);
            }
            // Base implementation does nothing
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Collect();
            }
        }
    }
}