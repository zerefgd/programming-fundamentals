using UnityEngine;

namespace Lesson10.Examples
{
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed = 5f;
        private void Update()
        {
            float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(new Vector3(moveX, 0, moveZ));
        }
    }
}