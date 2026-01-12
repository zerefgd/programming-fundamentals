using UnityEngine;

namespace Lesson05.Project
{
    public class Monster : MonoBehaviour
    {
        public string monsterName;
        public int powerLevel;

        public void Initialize(string newName,int newPower)
        {
            monsterName = newName;
            powerLevel = newPower;

            float scaleFactor = 1 + (powerLevel * 0.1f);
            transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
            GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.red, powerLevel / 10f);
        }
    }
}