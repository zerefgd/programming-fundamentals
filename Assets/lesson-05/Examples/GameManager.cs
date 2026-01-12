using UnityEngine;

namespace Lesson05.Examples
{
    [System.Serializable]
    public class PlayerStats
    {
        public int Health;
        public int Armor;
        public int Experience;
    }

    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerStats _playerStats;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log($"Player Stats - " +
                $"Health: {_playerStats.Health}, " +
                $"Armor: {_playerStats.Armor}, " +
                $"Experience: {_playerStats.Experience}");
        }
    }
}