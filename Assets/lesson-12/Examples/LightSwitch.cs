using UnityEngine;

namespace Lesson12.Examples
{

    public class LightSwitch : MonoBehaviour, IInteractable
    {
        private SpriteRenderer lightRenderer;
        private Color onColor = Color.yellow;
        private Color offColor = Color.gray;

        private void Awake()
        {
            lightRenderer = GetComponent<SpriteRenderer>();
        }

        public void Interact(GameObject interactor)
        {
            if (lightRenderer.color == offColor)
            {
                lightRenderer.color = onColor;
            }
            else
            {
                lightRenderer.color = offColor;
            }
        }
    }
}