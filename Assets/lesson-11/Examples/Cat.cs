using UnityEngine;

namespace Lesson11.Examples
{
     public class Cat : Animal
    {
        public override void MakeSound()
        {
            Debug.Log(petName + " says: Meow!");
        }
    }
}