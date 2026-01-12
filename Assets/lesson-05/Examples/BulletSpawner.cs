using UnityEngine;

namespace Lesson05.Examples
{
    public class BulletSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private int _bulletCount;
        [SerializeField] private float _spawnRadius;
        private void Start()
        {
            SpawnBullets();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullets();
            }
        }

        private void SpawnBullets()
        {
            for (int i = 0; i < _bulletCount; i++)
            {
                Vector2 spawnPosition = Random.insideUnitCircle * _spawnRadius;
                Instantiate(_bulletPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}