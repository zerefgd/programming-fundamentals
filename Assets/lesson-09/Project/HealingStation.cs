using System;
using UnityEngine;

namespace Lesson09.Project
{
    public class HealingStation : BaseInteractable
    {
        public int healAmount = 20;
        public float cooldownTime = 5f;
        private float nextAvailableTime = 0f;


        private void Awake()
        {
            objectName = "Healing Station";
        }

        public override void Interact(GameObject interactor)
        {            
            if (Time.time < nextAvailableTime)
            {
                Debug.Log(gameObject.name + " is cooling down. Please wait for "
                    + (nextAvailableTime - Time.time) + " seconds.");
                return;
            }
            PlayerHealth playerHealth = interactor.GetComponent<PlayerHealth>();
            if (playerHealth == null)
            {
                Debug.Log(interactor.name + " does not have a PlayerHealth component.");
            }
            playerHealth.Heal(healAmount);
            nextAvailableTime = Time.time + cooldownTime;
            Debug.Log(gameObject.name + " healed " + interactor.name + " for " + healAmount + " health.");
            SetInteractable(false);
            Invoke(nameof(ResetInteractable), cooldownTime);
        }

        private object ResetInteractable()
        {
            SetInteractable(true);
            return null;
        }
    }
}