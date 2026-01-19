using UnityEngine;

namespace Lesson07.Tasks
{
    public static class GameMath
    {
        public static Color GetRandomColor()
        {
            return new Color(Random.value, Random.value, Random.value);
        }
    }
}