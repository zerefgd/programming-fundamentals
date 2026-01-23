using UnityEngine;

namespace Lesson09.Examples
{
    public class WeaponController : MonoBehaviour
    {
        public BaseWeapon currentWeapon;
        private void Update()
        {
            if (Input.GetButtonDown("Fire1") && currentWeapon != null)
            {
                currentWeapon.Fire();
            }
        }

    }
}