using UnityEngine;

namespace Lesson03.Examples
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] _enemyPrefab;
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private int enemiesPerWave = 3;
        [SerializeField] private float timeBetweenWaves = 5f;
        private float _nextSpawnTime;
        private int _currentWave;

        private void Start()
        {
            if(_enemyPrefab.Length == 0 || _spawnPoints.Length == 0)
            {
                Debug.LogError("Enemy prefabs or spawn points not assigned!");
            }
            SpawnWave();
        }

        private void Update()
        {
            if (Time.time >= _nextSpawnTime)
            {
                SpawnWave();
                _nextSpawnTime = Time.time + timeBetweenWaves;
            }            
        }

        private void SpawnWave()
        {
            for (int i = 0; i < enemiesPerWave; i++)
            {
                Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
                GameObject enemyPrefab = _enemyPrefab[Random.Range(0, _enemyPrefab.Length)];
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            }
            _currentWave++;
            Debug.Log($"Wave {_currentWave} spawned with {enemiesPerWave} enemies.");
        }
    }
}