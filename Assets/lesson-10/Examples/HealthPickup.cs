using UnityEngine;

namespace Lesson10.Examples
{
    public class HealthPickup : Pickup
    {
        public int healthAmount = 25;
        public override void OnPickedUp(GameObject pickerUpper)
        {
            Debug.Log($"{pickerUpper.name} picked up a health pack worth {healthAmount} health!");
            // Here you could add code to increase the player's health
            PlayerHealth health = pickerUpper.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.Heal(healthAmount);
            }
        }
    }
}