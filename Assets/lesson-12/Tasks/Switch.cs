using UnityEngine;

namespace Lesson12.Tasks
{
    public class Switch : MonoBehaviour, ISwitchable
    {
        private Renderer _switchRenderer;
        private Color onColor = Color.green;
        private Color offColor = Color.red;

        private void Awake()
        {
            _switchRenderer = GetComponent<Renderer>();
            SwitchOff(); // Initialize switch to off state
        }

        public void SwitchOn()
        {
            _switchRenderer.material.color = onColor;
            Debug.Log("Switch is turned on.");
        }

        public void SwitchOff()
        {
            _switchRenderer.material.color = offColor;
            Debug.Log("Switch is turned off.");
        }
    }
}