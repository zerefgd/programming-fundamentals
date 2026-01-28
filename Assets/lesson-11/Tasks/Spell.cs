using UnityEngine;

namespace Lesson11.Tasks
{
    public abstract class Spell : MonoBehaviour
    {
        public int ManaCost { get; protected set; }
        public abstract void Cast();
        private void Start()
        {
            Cast();
        }
    }
}