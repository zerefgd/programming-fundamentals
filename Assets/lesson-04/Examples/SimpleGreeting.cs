using UnityEngine;

namespace Lesson04.Examples
{

    public class SimpleGreeting : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SimpleHello();
        }

        private void SimpleHello()
        {
            Debug.Log("Hello, welcome to Lesson 04!");
        }
    }
 }