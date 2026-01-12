using UnityEngine;

namespace Lesson04.Tasks
{

    public class MutiplyPrint : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Mulitply(5, 2);
        }

        void Mulitply(int a, int b)
        {
            int result = a * b;
            Debug.Log(result);
        }
    }
}