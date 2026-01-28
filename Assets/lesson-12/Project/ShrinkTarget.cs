using UnityEngine;

namespace Lesson12.Project
{
    public class ShrinkTarget : MonoBehaviour,IShootable
    {
        public void OnHit()
        {
            transform.localScale *= 0.8f;
        }
    }
}