using UnityEngine;

namespace Lesson09.Examples
{
    public class PistolWeapon : BaseWeapon
    {
        [Header("Pistol Specific Stats")]
        public int roundsPerBurst = 1;

        private void Awake()
        {
            damage = 15f;
            fireRate = 0.75f;
        }


        public override void Fire()
        {
            Debug.Log("PistolWeapon: Firing pistol with " + roundsPerBurst + " rounds per burst.");
            base.Fire();
        }
    }
}