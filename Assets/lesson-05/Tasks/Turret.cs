using UnityEngine;

namespace Lesson05.Tasks
{
    public class Turret : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 30f;

        private void Update()
        {
            transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        }
    }
}