using UnityEngine;

namespace Lesson04.Tasks
{
    public class Teleporter : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.T))
            {
                Teleport(10f);
            }
        }

        private void Teleport(float distance)
        {
            float moveX = Random.Range(-distance, distance);
            float moveZ = Random.Range(-distance, distance);
            transform.position = new Vector3(moveX, transform.position.y, moveZ);
            Debug.Log($"Teleported to: {transform.position}");
        }
    }
}