using UnityEngine;

namespace Lesson09.Examples
{
    public class AimalTester : MonoBehaviour
    {
        public BaseAnimal dogReference;
        public BaseAnimal catReference;

        private void Start()
        {
            if(dogReference != null)
            {
                dogReference.animalName = "Buddy";
                dogReference.age = 3;
                dogReference.MakeSound();
                dogReference.Describe();
                if (dogReference is Dog dog)
                {
                    dog.Breed = "Labrador";
                    dog.ChaseTail();
                }
            }
            if(catReference != null)
            {
                catReference.animalName = "Whiskers";
                catReference.age = 2;
                catReference.MakeSound();
                catReference.Describe();
                if (catReference is Cat cat)
                {
                    cat.FurColor = "Calico";
                    cat.Pounce();
                }
            }
        }
    }
}