using UnityEngine;

namespace Lesson08.Project
{
    [System.Serializable]
    public class LightCycle
    {
        public string colorName = "Red";
        public float duration = 2f;
        private float timer = 0f;

        public bool IsTimeUp(float deltaTime)
        {
            timer += deltaTime;
            if (timer >= duration)
            {
                timer = 0f;
                return true;
            }
            return false;
        }
    }
}