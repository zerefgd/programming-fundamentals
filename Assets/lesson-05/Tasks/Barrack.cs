using UnityEngine;
using System.Collections.Generic;

namespace Lesson05.Tasks
{
    public class Barrack : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _soldierPrefabs;
        private void Start()
        {
            for(int i = 0; i < _soldierPrefabs.Count; i++)
            {
                if (_soldierPrefabs[i] == null) continue;
                _soldierPrefabs[i].name = "Private" + (i + 1);
            }
        }
    }
}