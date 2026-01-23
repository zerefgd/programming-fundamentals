using UnityEngine;

namespace Lesson09.Examples
{
    public class BaseAnimal : MonoBehaviour
    {
        public string animalName = "Animal";
        public int age = 0;
        public virtual void MakeSound()
        {
            Debug.Log($"{animalName} makes a generic animal sound.");
        }

        public void Describe()
        {
            Debug.Log($"This is {animalName}, and it is {age} years old.");
        }
    }
}