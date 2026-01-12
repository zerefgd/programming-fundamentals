using UnityEngine;

namespace Lesson05.Project
{
    public class MonsterGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject _monsterPrefab;
        [SerializeField] private int _monsterCount;
        [SerializeField] private float _spawnRadius;
        private void Start()
        {
            GenerateMonsters();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                GenerateMonsters();
            }
        }

        private void GenerateMonsters()
        {
            for (int i = 0; i < _monsterCount; i++)
            {
                Vector2 spawnPosition = Random.insideUnitCircle * _spawnRadius;
                GameObject monsterObject = Instantiate(_monsterPrefab, spawnPosition, Quaternion.identity);
                Monster monster = monsterObject.GetComponent<Monster>();
                string monsterName = "Monster_" + Random.Range(1, 1000);
                int powerLevel = Random.Range(1, 11);
                monster.Initialize(monsterName, powerLevel);
            }
        }
    }
}