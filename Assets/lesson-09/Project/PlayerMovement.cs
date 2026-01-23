using UnityEngine;

namespace Lesson09.Project
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 5f;
        public float rotateSpeed = 180f;
        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = moveVertical * transform.forward;
            transform.Translate(movement.normalized * speed * Time.deltaTime, Space.World);
            transform.Rotate(0, moveHorizontal * rotateSpeed * Time.deltaTime, 0);
        }
    }
}