using UnityEngine;

namespace Lesson02.Tasks
{
    public class AmmoCounter : MonoBehaviour
    {
        [SerializeField] private int ammoCount = 30;
        private int currentAmmo;

        private void Start()
        {
            currentAmmo = ammoCount;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && currentAmmo > 0)
            {
                currentAmmo--;
                Debug.Log($"Ammo left: {currentAmmo}");
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                currentAmmo = ammoCount;
                Debug.Log("Reloaded!");
            }

            if (currentAmmo == 0)
            {
                Debug.Log("Out of ammo! Press 'R' to reload.");
            }
        }
    }
}