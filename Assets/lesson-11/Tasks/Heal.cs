using UnityEngine;

namespace Lesson11.Tasks
{
    public class Heal : Spell
    {
        public override void Cast()
        {
            Debug.Log("Casting Heal spell.");
        }
    }
}