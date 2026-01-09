using UnityEngine;

namespace Lesson01.Project
{
    public class SwitchButton : MonoBehaviour
    {
        public LightController lightController;
        private bool isOn = false;
        public bool IsOn => isOn;
        void OnMouseDown()
        {
            isOn = !isOn;
            Debug.Log(gameObject.name + " SwitchButton clicked. isOn: " + isOn);
            lightController.CheckAllSwitches();
        }
    }
}