using UnityEngine;

namespace Lesson09.Examples
{

    public class HealthPackCollectible : BaseCollectible
    {
        public int healthAmount = 25;
        public override void Collect()
        {
            Debug.Log($"HealthPackCollectible collected! Health Amount: {healthAmount}");
            // Here you could add code to increase the player's health
            base.Collect();
        }

        protected override void PlayCollectEffect()
        {
            Debug.Log("Playing health pack collect effect.");
            base.PlayCollectEffect();
        }
    }
}