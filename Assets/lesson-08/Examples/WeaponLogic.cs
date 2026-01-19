using UnityEngine;

namespace Lesson08.Examples
{
    [System.Serializable]
    public class WeaponLogic
    {
        public int damage = 10;
        public float reloadTime = 2f;
        public void UpgradeDamage()
        {
            damage += 5;
            Debug.Log($"Weapon damage upgraded to {damage}");
        }
    }
}