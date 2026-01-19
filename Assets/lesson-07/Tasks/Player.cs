using UnityEngine;

namespace Lesson07.Tasks
{
    public class Player : MonoBehaviour
    {
        private SpriteRenderer playerRenderer;
        private void Start()
        {
            playerRenderer = GetComponent<SpriteRenderer>();
            playerRenderer.color = GameMath.GetRandomColor();
        }
    }
}