using UnityEngine;

namespace Lesson08.Examples
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField] private WeaponLogic weaponLogic = new WeaponLogic();
        private void Start()
        {
            Debug.Log($"Initial weapon damage: {weaponLogic.damage}");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                weaponLogic.UpgradeDamage();
            }
        }
    }
}