using UnityEngine;

namespace Lesson02.Project
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;

        private void Update()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");
            Vector3 movement = moveSpeed * Time.deltaTime * new Vector3(moveX, moveY, 0f);
            transform.position += movement;
        }
    }
}