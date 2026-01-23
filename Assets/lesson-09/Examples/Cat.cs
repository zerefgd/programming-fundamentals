using UnityEngine;

namespace Lesson09.Examples
{

    public class Cat : BaseAnimal
    {
        public string FurColor = "Tabby";
        public override void MakeSound()
        {
            Debug.Log($"{animalName} meows: Meow Meow!");
        }
        public void Pounce()
        {
            Debug.Log($"{animalName} is pouncing!");
        }
    }
}