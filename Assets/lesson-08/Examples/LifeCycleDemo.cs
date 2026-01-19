using UnityEngine;

namespace Lesson08.Examples
{
    public class LifeCycleDemo : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("1. Awake called");
        }

        private void Start()
        {
            Debug.Log("3. Start called");
        }

        private void OnEnable()
        {
            Debug.Log("2. OnEnable called");
        }

        private void Update()
        {
            Debug.Log("4. Update called");
        }

        private void OnDisable()
        {
            Debug.Log("5. OnDisable called");
        }

        private void OnDestroy()
        {
            Debug.Log("6. OnDestroy called");
        }
    }
}