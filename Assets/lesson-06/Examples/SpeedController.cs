using UnityEngine;

namespace Lesson06.Examples
{
    public class SpeedController : MonoBehaviour
    {
        [SerializeField] private float _testSpeed = 5f;
        private float speed = 5f;
        public float Speed
        {
            get => speed;
            set
            {
                if(value < 0)
                {
                    Debug.LogWarning("Speed cannot be negative. Setting to 0.");
                    speed = 0;
                }
                else if(value > 20)
                {
                    Debug.LogWarning("Speed cannot exceed 20. Setting to 20.");
                    speed = 20;
                }
                else
                {
                    speed = value;
                }
            }
        }

        private void Start()
        {
            Speed = _testSpeed;
        }

        private void Update()
        {
            float move = Speed * Time.deltaTime;
            transform.Translate(Vector3.forward * move);
        }
    }
}