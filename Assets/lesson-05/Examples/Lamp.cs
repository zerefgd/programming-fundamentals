using UnityEngine;

namespace Lesson05.Examples
{
    public class Lamp : MonoBehaviour
    {
        [SerializeField] private Color _lampColor;
        [SerializeField] private bool _isOn;

        private void Start()
        {
            ToggleLight();
        }

        private void ToggleLight()
        {
            _isOn = !_isOn;
            if (_isOn)
            {
                Debug.Log($"The lamp with name {gameObject.name} is now ON with color {_lampColor}.");
            }
            else
            {
                Debug.Log($"The lamp with name {gameObject.name} is now OFF.");
            }
        }
    }
}