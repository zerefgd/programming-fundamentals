using UnityEngine;

namespace Lesson12.Project
{
    public class ColorChangeTarget : MonoBehaviour,IShootable
    {
        private Renderer _renderer;
        private Color _defaultColor = Color.white;

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _renderer.material.color = _defaultColor;
        }

        public void OnHit()
        {
            StopAllCoroutines();
            StartCoroutine(ChangeColorRoutine());
        }
        private System.Collections.IEnumerator ChangeColorRoutine()
        {
            Color hitColor = Random.ColorHSV();
            _renderer.material.color = hitColor;
            yield return new WaitForSeconds(0.5f);
            _renderer.material.color = _defaultColor;
        }
    }
}