using UnityEngine;

namespace Lesson02.Tasks
{

    public class ToggleVisibility : MonoBehaviour
    {
        private SpriteRenderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();                
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.V))
            {
                if ( _renderer == null )
                {
                    Debug.LogWarning("SpriteRenderer component is missing!");
                    return;
                }
                _renderer.enabled = !_renderer.enabled;
            }
        }
    }
}