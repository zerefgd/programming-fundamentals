using UnityEngine;

namespace Lesson10.Examples
{
    public class CoinPickup : Pickup
    {
        public int coinValue = 1;
        public override void OnPickedUp(GameObject pickerUpper)
        {
            Debug.Log($"{pickerUpper.name} picked up a coin worth {coinValue}!");
            // Here you could add code to increase the player's coin count
            PlayerInventory inventory = pickerUpper.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.AddCoins(coinValue);
            }
        }
    }
}