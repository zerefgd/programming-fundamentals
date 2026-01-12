using UnityEngine;

namespace Lesson06.Project
{
    public class EnergySystem : MonoBehaviour
    {

        [SerializeField] private float _maxEnergy;
        private float enery;

        public float Energy
        {
            get => enery;
            set
            {
                if (value < 0)
                {
                    Debug.LogWarning("Energy cannot be negative. Setting to 0.");
                    enery = 0;
                }
                else if (value > _maxEnergy)
                {
                    Debug.LogWarning($"Energy cannot exceed {_maxEnergy}. Setting to {_maxEnergy}.");
                    enery = _maxEnergy;
                }
                else
                {
                    enery = value;
                }
            }
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Energy = _maxEnergy;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Energy += 10;
                Debug.Log($"Increased Energy: {Energy}");
            }

            if(Input.GetKeyDown(KeyCode.D))
            {
                Energy += 500;
                Debug.Log($"Increased Energy by large amount: {Energy}");
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Energy -= 10;
                Debug.Log($"Decreased Energy: {Energy}");
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                Energy = _maxEnergy;
                Debug.Log($"Restored Energy to Max: {Energy}");
            }
        }
    }
}