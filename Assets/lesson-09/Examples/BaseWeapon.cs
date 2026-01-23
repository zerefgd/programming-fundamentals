using UnityEngine;

namespace Lesson09.Examples
{
    public class BaseWeapon : MonoBehaviour
    {
        [Header("Base Weapon Stats")]
        public float damage = 10f;
        public float fireRate = 1f;
        public GameObject ProjectilePrefab;
        public Transform firePoint;

        protected float nextFireTime = 0f;

        public virtual void Fire()
        {
            if(Time.time < nextFireTime)
                return;
            nextFireTime = Time.time + fireRate;
            Debug.Log("BaseWeapon: Firing weapon.");
            // Instantiate projectile at firePoint position and rotation
            if (ProjectilePrefab != null && firePoint != null)
            {
                Instantiate(ProjectilePrefab, firePoint.position, firePoint.rotation);
            }
            else
            {
                Debug.LogWarning("BaseWeapon: ProjectilePrefab or firePoint is not assigned.");
            }
        }
    }
}