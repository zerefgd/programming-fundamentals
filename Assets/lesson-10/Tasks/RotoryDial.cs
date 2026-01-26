using UnityEngine;

namespace Lesson10.Tasks
{
    public class RotoryDial : MonoBehaviour,IPuzzleElement
    {
        public int currentRotation = 0;
        public int targetRotation = 2;
        public Material[] dialMaterials;
        private Renderer dialRenderer;

        private void Awake()
        {
            dialRenderer = GetComponent<Renderer>();
            UpdateDialAppearance();
        }

        public bool IsSolved()
        {
            return currentRotation == targetRotation;
        }

        public void Interact()
        {
            currentRotation = (currentRotation + 1) % dialMaterials.Length;
            Debug.Log("Dial rotated to position " + currentRotation);
            UpdateDialAppearance();
        }

        public string GetHintText()
        {
            return "Rotate the dial to the correct position.";
        }

        private void UpdateDialAppearance()
        {
            if (dialRenderer != null && dialMaterials.Length > 0)
            {
                dialRenderer.material = dialMaterials[currentRotation];
            }
        }
    }
}