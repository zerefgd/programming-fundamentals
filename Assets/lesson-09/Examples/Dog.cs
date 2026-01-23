using UnityEngine;

namespace Lesson09.Examples
{

    public class Dog : BaseAnimal
    {
        public string Breed = "Golden Retriever";

        public override void MakeSound()
        {
            Debug.Log($"{animalName} barks: Woof Woof!");
        }

        public void ChaseTail()
        {
            Debug.Log($"{animalName} is chasing its tail!");
        }
    }
}