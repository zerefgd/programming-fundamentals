using UnityEngine;

namespace Lesson04.Project
{
    public class PotionMaster : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                DrinkPotion(Color.red,2.0f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                DrinkPotion(Color.blue, 0.5f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                DrinkPotion(Random.ColorHSV(), 1f);
            }
        }

        private void DrinkPotion(Color color, float duration)
        {
            _meshRenderer.material.color = color;
            transform.localScale = Vector3.one * duration;
            Invoke("ResetCube", duration);
        }

        private void ResetCube()
        {
            _meshRenderer.material.color = Color.white;
            transform.localScale = Vector3.one;
        }
    }
}