using UnityEngine;

namespace Lesson07.Tasks
{
    public class Minion : MonoBehaviour
    {
        public static int totalMinions = 0;
        public int minionID;

        private void Start()
        {
            totalMinions++;
            minionID = totalMinions;
            Debug.Log($"Minion {minionID} created. Total minions: {totalMinions}");
        }
    }
}