using UnityEngine;

namespace Lesson11.Examples
{
    public abstract class Animal : MonoBehaviour
    {
        public string petName;
        public abstract void MakeSound();
        public void Sleep()
        {
            Debug.Log(petName + " is sleeping.");
        }

        private void Start()
        {
            MakeSound();
        }
    }
}