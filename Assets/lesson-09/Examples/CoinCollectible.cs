using UnityEngine;

namespace Lesson09.Examples
{
    public class CoinCollectible : BaseCollectible
    {
        public int coinValue = 1;
        public override void Collect()
        {
            Debug.Log($"CoinCollectible collected! Value: {coinValue}");
            // Here you could add code to update the player's coin count
            base.Collect();
        }

        protected override void PlayCollectEffect()
        {
            Debug.Log("Playing coin collect effect.");
            base.PlayCollectEffect();
        }
    }
}