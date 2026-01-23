using UnityEngine;

namespace Lesson09.Examples
{
    public class ShotgunWeapon : BaseWeapon
    {
        [Header("Shotgun Settings")]
        public int pelletsPerShot = 8;
        public float spreadAngle = 30f;

        private void Awake()
        {
            damage = 8f;
            fireRate = 1.5f;
        }

        public override void Fire()
        {
            if (Time.time < nextFireTime)
                return;
            nextFireTime = Time.time + fireRate;
            Debug.Log("ShotgunWeapon: Firing shotgun with " + pelletsPerShot + " pellets.");
            if (ProjectilePrefab == null || firePoint == null)
            {
                Debug.LogWarning("ShotgunWeapon: ProjectilePrefab or firePoint is not assigned.");
            }

            for (int i = 0; i < pelletsPerShot; i++)
            {
                float angle = Random.Range(-spreadAngle / 2, spreadAngle / 2);
                Quaternion pelletRotation = firePoint.rotation * Quaternion.Euler(0, angle, 0);
                var pellet = Instantiate(ProjectilePrefab, firePoint.position, pelletRotation);
                pellet.GetComponent<Rigidbody>().linearVelocity = pellet.transform.forward * 20f; // Example speed
            }
        }
    }
}