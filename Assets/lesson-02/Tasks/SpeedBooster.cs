using UnityEngine;

namespace Lesson02.Tasks
{
    public class SpeedBooster : MonoBehaviour
    {
        [SerializeField] private float originalSpeed = 5f;
        private float currentSpeed;

        private void Start()
        {
            currentSpeed = originalSpeed;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                currentSpeed = originalSpeed * 2;
                Debug.Log($"Speed boosted to: {currentSpeed}");
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                currentSpeed = originalSpeed;
                Debug.Log($"Speed reverted to: {currentSpeed}");
            }
            Debug.Log($"Current Speed: {currentSpeed}");
            transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
        }
    }
}