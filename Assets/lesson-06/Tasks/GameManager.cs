using UnityEngine;

namespace Lesson06.Tasks
{

    public class GameManager : MonoBehaviour
    {
        [SerializeField] private int _maxHealth = 100;
        [SerializeField] private MeshRenderer _playerRenderer;
        [SerializeField] private Color _activeColor, _inactiveColor;
        private int health;
        private bool isActive;
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                if(_playerRenderer != null)
                    _playerRenderer.material.color = isActive ? _activeColor : _inactiveColor;
            }
        }
        public int Health
        {
            get => health;
            set
            {
                if (value < 0)
                {
                    Debug.LogWarning("I cannot die. I am invincible");
                    health = 1;
                }
                else if (value > _maxHealth)
                {
                    Debug.LogWarning($"Health cannot exceed {_maxHealth}. Setting to {_maxHealth}.");
                    health = (int)_maxHealth;
                }
                else
                {
                    health = value;
                }
            }
        }
        public int Level { get; private set; }
        private void Start()
        {
            Health = _maxHealth;
            IsActive = true;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Health -= 10;
                Debug.Log($"Decreased Health: {Health}");
            }

            if(Input.GetKeyDown(KeyCode.I))
            {
                IsActive = !IsActive;
                Debug.Log($"Toggled IsActive: {IsActive}");
            }

            if(Input.GetKeyDown(KeyCode.L))
            {
                Level++;
                Debug.Log($"Increased Level: {Level}");
            }
        }
    }
}