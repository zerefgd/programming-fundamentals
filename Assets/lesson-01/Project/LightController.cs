using UnityEngine;

namespace Lesson01.Project
{
    public class LightController : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _lightSprite;
        [SerializeField] private Sprite _lightOnSprite;
        [SerializeField] private Sprite _lightOffSprite;

        [SerializeField] private SwitchButton _switch1;
        [SerializeField] private SwitchButton _switch2;
        [SerializeField] private SwitchButton _switch3;

        private void Start()
        {
            if (_lightSprite == null)
            {
                Debug.LogError("LightController: _lightSprite is not assigned.");
                return;
            }
            _lightSprite.sprite = _lightOffSprite;
        }

        public void CheckAllSwitches()
        {
            if (_switch1.IsOn && _switch2.IsOn && _switch3.IsOn)
            {
                _lightSprite.sprite = _lightOnSprite;
                Debug.Log("All switches are ON. Light is ON.");
            }
            else
            {
                _lightSprite.sprite = _lightOffSprite;
                Debug.Log("Not all switches are ON. Light is OFF.");
            }
        }
    }
}