using UnityEngine;

namespace Lesson03.Tasks
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _enemyPrefabs;
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private float _spawnInterval = 3f;
        [SerializeField] private int _initialEnemyCount = 5;

        private int currentWave;
        private float nextSpawnTime;

        private void Start()
        {
            currentWave = 1;
            nextSpawnTime = Time.time + _spawnInterval;
        }

        private void Update()
        {
            if (Time.time >= nextSpawnTime)
            {
                SpawnEnemies(currentWave);
                currentWave++;
                nextSpawnTime = Time.time + _spawnInterval;
            }
        }

        private void SpawnEnemies(int wave)
        {
            int enemiesToSpawn = _initialEnemyCount * wave;
            int difficultyModifier = Mathf.Clamp((int)(wave / 2f), 0, 4);
            for (int i = 0; i < enemiesToSpawn; i++)
            {
                int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
                int enemyPrefabIndex = Mathf.Min(difficultyModifier, _enemyPrefabs.Length - 1);
                var enemy = Instantiate(_enemyPrefabs[enemyPrefabIndex], _spawnPoints[spawnPointIndex].position, Quaternion.identity);
                enemy.transform.localScale *= 1 + (difficultyModifier * 0.2f);
            }
        }
    }
}