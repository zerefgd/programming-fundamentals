using UnityEngine;

namespace Lesson07.Examples
{

    public class Dog : MonoBehaviour
    {
        public string dogName;
        public static int dogCount = 0;

        private void Start()
        {
            dogCount++;
            Debug.Log($"Dog {dogName} has been created. Total dogs: {dogCount}");
        }
    }
}