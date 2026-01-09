using UnityEngine;

namespace Lesson01.Tasks
{
    public class Greeting : MonoBehaviour
    {
        private string playerName;

        private void Start()
        {
            playerName = "alex";
            Debug.Log($"Hello, {playerName}!");
        }
    }
}