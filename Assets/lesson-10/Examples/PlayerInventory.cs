using UnityEngine;

namespace Lesson10.Examples
{
    public class PlayerInventory : MonoBehaviour
    {
        public int coins = 0;
        private void Start()
        {
            Debug.Log("PlayerInventory initialized with " + coins + " coins.");
        }

        public void AddCoins(int amount)
        {
            coins += amount;
            Debug.Log("Added " + amount + " coins. Total now: " + coins);
        }
    }
}