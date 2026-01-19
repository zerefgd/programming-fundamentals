using UnityEngine;

namespace Lesson08.Project
{
    public class TrafficController : MonoBehaviour
    {
        public LightCycle myCycle;
        private SpriteRenderer myRenderer;

        private void Awake()
        {
            myRenderer = GetComponent<SpriteRenderer>();
            myCycle = new LightCycle();
            UpdateColor(Color.red);
        }

        private void UpdateColor(Color newColor)
        {
            if (myRenderer != null)
            {
                myRenderer.color = newColor;
            }
        }

        private void Update()
        {
            if(myCycle.IsTimeUp(Time.deltaTime))
            {
                if (myCycle.colorName == "Red")
                {
                    myCycle.colorName = "Green";
                    UpdateColor(Color.green);
                }
                else
                {
                    myCycle.colorName = "Red";
                    UpdateColor(Color.red);
                }
                Debug.Log("Light changed to: " + myCycle.colorName);
            }
        }
    }
}