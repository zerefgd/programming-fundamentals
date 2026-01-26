using UnityEngine;

namespace Lesson10.Tasks
{
    public interface IPuzzleElement
    {
        bool IsSolved();
        void Interact();
        string GetHintText();
    }

    public class PressurePlate : MonoBehaviour, IPuzzleElement
    {
        public bool isPressed = false;
        public Material pressedMaterial;
        public Material unpressedMaterial;
        private Renderer plateRenderer;

        private void Awake()
        {
            plateRenderer = GetComponent<Renderer>();
            UpdatePlateAppearance();
        }

        public bool IsSolved()
        {
            return isPressed;
        }

        public void Interact()
        {
            isPressed = !isPressed;
            Debug.Log("Pressure Plate is now " + (isPressed ? "Pressed" : "Unpressed"));
            UpdatePlateAppearance();
        }

        public string GetHintText()
        {
            return "Step on the pressure plate to activate it.";
        }

        private void UpdatePlateAppearance()
        {
            if (plateRenderer != null)
            {
                plateRenderer.material = isPressed ? pressedMaterial : unpressedMaterial;
            }
        }
    }
}