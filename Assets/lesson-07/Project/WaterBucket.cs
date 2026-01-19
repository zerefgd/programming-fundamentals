using TMPro;
using UnityEngine;

namespace Lesson07.Project
{
    public class WaterBucket : MonoBehaviour
    {
        public int personalWater = 0;
        public static int globalWater = 0;
        public TMP_Text globalWaterText;

        private void OnMouseDown()
        {
            personalWater++;
            globalWater++;
            globalWaterText.text = "Global Water: " + globalWater;
            Debug.Log("Personal Water: " + personalWater);
        }

        private void OnApplicationQuit()
        {
            globalWater = 0;
        }
    }
}