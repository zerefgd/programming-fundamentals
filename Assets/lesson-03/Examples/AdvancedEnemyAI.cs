using UnityEngine;
using UnityEngine.AI;
namespace Lesson03.Examples
{
    public class AdvancedEnemyAI : MonoBehaviour
    {
        public enum EnemyState
        {
            Patrolling,
            Chasing,
            Attacking
        }

        private EnemyState currentState;

        [SerializeField] private Transform[] _patrolPoints;
        [SerializeField] private float _detectionRange = 10f;
        [SerializeField] private float _attackRange = 2f;
        private Transform player;
        private NavMeshAgent _navMeshAgent;
        private int currentPatrolIndex = 0;

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            player = GameObject.FindGameObjectWithTag("Player").transform;

            if (_navMeshAgent == null)
            {
                Debug.LogError("NavMeshAgent component not found!");
                this.enabled = false;
                return;
            }

            if (_patrolPoints.Length == 0)
            {
                Debug.LogError("No patrol points assigned!");
                this.enabled = false;
                return;
            }

            currentState = EnemyState.Patrolling;
            currentPatrolIndex = 0;
            _navMeshAgent.SetDestination(_patrolPoints[currentPatrolIndex].position);
        }

        private void Update()
        {
            switch (currentState)
            {
                case EnemyState.Patrolling:
                    Patrol();
                    break;
                case EnemyState.Chasing:
                    ChasePlayer();
                    break;
                case EnemyState.Attacking:
                    AttackPlayer();
                    break;
            }
        }

        private void Patrol()
        {
            if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
            {
                currentPatrolIndex = (currentPatrolIndex + 1) % _patrolPoints.Length;
                _navMeshAgent.SetDestination(_patrolPoints[currentPatrolIndex].position);
            }

            if(player == null)
                return;

            if (Vector3.Distance(transform.position, player.position) <= _detectionRange)
            {
                currentState = EnemyState.Chasing;
            }
        }

        private void ChasePlayer()
        {
            if(player == null)
                return;

            _navMeshAgent.SetDestination(player.position);

            if (Vector3.Distance(transform.position, player.position) <= _attackRange)
            {
                currentState = EnemyState.Attacking;
            }
            else if (Vector3.Distance(transform.position, player.position) > _detectionRange)
            {
                currentState = EnemyState.Patrolling;
                _navMeshAgent.SetDestination(_patrolPoints[currentPatrolIndex].position);
            }
        }

        private void AttackPlayer()
        {
            // Implement attack logic here

            if(player == null)
                return;

            if (Vector3.Distance(transform.position, player.position) > _attackRange)
            {
                currentState = EnemyState.Chasing;
            }
        }
    }
}