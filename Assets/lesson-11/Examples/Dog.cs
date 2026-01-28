using UnityEngine;

namespace Lesson11.Examples
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Debug.Log(petName + " says: Woof!");
        }
    }
}