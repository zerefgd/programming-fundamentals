using UnityEngine;


namespace Lesson02.Examples
{

    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private float detectionRange = 10f;        
        [SerializeField] private float moveSpeed = 3f;
        private bool isChasing;


        private void Start()
        {
            isChasing = false;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
                isChasing = !isChasing;
                Debug.Log("Chasing mode toggled: " + isChasing);
            }
            if (!isChasing) return;
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            if (distanceToPlayer <= detectionRange)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                transform.position += direction * moveSpeed * Time.deltaTime;
                Debug.Log("Enemy is chasing the player.");
            }
        }
    }
}